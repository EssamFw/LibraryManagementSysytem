using BusinessLayer.DTOs.Transactions;
using BusinessLayer.Services.Tranactions;
using LibraryManagementSysytem.ActionRequests.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace LibraryManagementSysytem.Controllers
{
    public class TransactionBController : Controller
    {

        private readonly ITranactionService _transactionService;
        public TransactionBController(ITranactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> create(CreateTransActionBActionRequest transaction)
        {
            if (ModelState.IsValid)
            { 
                AddTransactionDTO transactionDTO = new AddTransactionDTO()
                {
                    Total_Cost       = transaction.Total_Cost,
                    CheckOut_Date    = transaction.CheckOut_Date,
                    Due_Date         = transaction.Due_Date,
                    OverDueDate_Days = transaction.OverDueDate_Days,
                    Return_Date      = transaction.Return_Date,
                    LibrarianID_FK   = transaction.LibrarianID_FK,
                    MemberID_FK      = transaction.MemberID_FK,
                  

                };
            await _transactionService.AddTransaction(transactionDTO);
            TempData["Success"] = "تم الإضافة بنجاح";

            return RedirectToAction("Index");
            }
            return View();
        }
    }
}
