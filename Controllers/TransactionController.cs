using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sample_Project.Data;
using Sample_Project.Models;

namespace Sample_Project.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionRepo _repository;
        private readonly IMapper _mapper;

        public ActionResult SubmitPayment()
        {
            return View();
        }

       /* public TransactionController(ITransactionRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
       */

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitPayment(TransactionModel transaction)
        {
            if (ModelState.IsValid) 
            {
                /* run a call to API method to validate 
                 * process the transaction back to the 
                 * payment validation service and receive status
                 */
                bool paymentStatus = true; // hard-coded for testing w/o integration

                // savePaymenttoDatabase

                if (paymentStatus == true)
                {
                    ViewData["Success"] = "Payment successful";
                    ModelState.Clear();
                    return View();

                }
                else
                {
                    ModelState.AddModelError("", "Payment failed - please try again");
                    return View(transaction);
                }
                //return RedirectToAction("ListTransactions");
            }   
            return View();
        }

        public ActionResult <IEnumerable<TransactionModel>>ListTransactions()
        {
            var transactions = _repository.GetApprovedTransactions();

            return View(_mapper.Map<IEnumerable<TransactionModel>>(transactions));
            // _mapper.Map<IEnumerable<CommandReadDto>>(commandItems)

        } 
    }
}