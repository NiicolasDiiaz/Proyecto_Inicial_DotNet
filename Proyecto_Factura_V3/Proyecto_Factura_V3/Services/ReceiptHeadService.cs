using Proyecto_Factura_V3.Models;
using Proyecto_Factura_V3.Repositories;
using Proyecto_Factura_V3.Request;
using Proyecto_Factura_V3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Factura_V3.Services
{
    public class ReceiptHeadService : IReceiptHeadService
    {
        private readonly IReceiptHeadRepository _repository;
        private readonly IReceiptDetailRepository _detailRepository;

        public ReceiptHeadService(IReceiptHeadRepository repository, IReceiptDetailRepository detailRepository)
        {
            _repository = repository;
            _detailRepository = detailRepository;
        }

        public async Task<ReceiptHeadView> viewMapper(ReceiptHead entity)
        {
            List<ReceiptDetailView> receiptDetailViews = new List<ReceiptDetailView>();
            foreach (var item in entity.ReceiptDetails)
            {
                receiptDetailViews.Add(await _detailRepository.ViewMapper(item));
            }
            
            return new ReceiptHeadView
            {
                BranchAddress = entity.Branch.Address,
                BranchCity = entity.Branch.City,
                BranchName = entity.Branch.Name,
                BranchPhone = entity.Branch.Phone,
                CustomerId = entity.CustomerId,
                CustomerName = entity.Customer.FirstName + " " + entity.Customer.LastName,
                Date = entity.Date,
                FinalValue = entity.FinalValue,
                ReceiptHeadId = entity.ReceiptHeadId,
                ReceiptDetails = receiptDetailViews
            };
        }

        public async Task<ReceiptHeadView> GetId(int id)
        {
            var model = await _repository.GetId(id);
            return await viewMapper(model);
        }

        public async Task<List<ReceiptHeadView>> GetAll()
        {
            List<ReceiptHeadView> receiptHeadViews = new List<ReceiptHeadView>();
            var model = await _repository.GetAll();
            foreach (var item in model)
            {
                receiptHeadViews.Add(await viewMapper(item));
            }
            return receiptHeadViews;
        }


        public async Task<ReceiptHeadView> AddEntity(ReceiptHeadRequest entity)
        {
            var model = await _repository.AddEntity(new ReceiptHead
            {
                BranchId = entity.BranchId,
                CustomerId = entity.CustomerId,
                Date = DateTime.Now
            });

            double finalValue = 0;
            foreach (var item in entity.ReceiptDetails)
            {
                var modelDetail = await _detailRepository.AddEntity(item, model.ReceiptHeadId);
                finalValue += modelDetail.TotalValue;
            }

            model.FinalValue = finalValue;
            await UpdateEntity(model);
            return await viewMapper(model);
        }

        public async Task<ReceiptHeadView> UpdateEntity(ReceiptHead entity)
        {
            var model = await _repository.UpdateEntity(entity);
            return await viewMapper(model);
        }


        public async Task DeleteEntity(ReceiptHead entity)
        {
            await _repository.DeleteEntity(entity);
        }

        public async Task DeleteId(int id)
        {
            await _repository.DeleteId(id);
        }
    }
}
