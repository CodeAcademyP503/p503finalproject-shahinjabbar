using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using finalProject.Models;
using finalProject.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Remotion.Linq.Clauses;
using finalProject.Views.ViewModels;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;

namespace finalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProviderDbContext providerDbContext;

        public HomeController(ProviderDbContext _providerDbContext)
        {
            providerDbContext = _providerDbContext;
        }

        public async Task<IActionResult> Index(int id = 1)
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.TopProviderViewModels = await (from lang in providerDbContext.LanguageConfigurations
                                                         join topprov in providerDbContext.TopProviders on lang.Id equals topprov.LangId
                                                         where lang.Id == id
                                                         select new TopProviderViewModel
                                                         {
                                                             BackColor = topprov.BackColor,
                                                             TagName = topprov.TagName,
                                                             Logo = topprov.ImagePath,
                                                             Id = topprov.DataId
                                                         }).ToListAsync();

            homeViewModel.CoreProviderViewModels = await (from lang in providerDbContext.LanguageConfigurations
                                                          join coreprov in providerDbContext.CoreProviders on lang.Id equals coreprov.LangId
                                                          where lang.Id == id
                                                          select new CoreProviderViewModel
                                                          {
                                                              BackColor = coreprov.BackColor,
                                                              TagName = coreprov.TagName,
                                                              Logo = coreprov.ImagePath,
                                                              Text = coreprov.Text,
                                                              Id = coreprov.Id
                                                          }).ToListAsync();

            homeViewModel.LangId = await (from lang in providerDbContext.LanguageConfigurations
                                          select new LangViewModel
                                          {
                                              id = lang.Id,
                                              ImagePath = lang.PhotoPath
                                          }).ToListAsync();

            homeViewModel.IndexPhoto = await (from lang in providerDbContext.LanguageConfigurations
                                              join index in providerDbContext.IndexPhotos on lang.Id equals index.LangId
                                              where lang.Id == id
                                              select index.PhotoPath).ToListAsync();

            homeViewModel.FooterText = await (from lang in providerDbContext.LanguageConfigurations
                                              join footer in providerDbContext.FooterInfos on lang.Id equals footer.LangId
                                              where lang.Id == id
                                              select footer.Text).ToListAsync();

            homeViewModel.LanguageId = await (from lang in providerDbContext.LanguageConfigurations
                                              where lang.Id == id
                                              select lang.Id).FirstOrDefaultAsync();
            return View(homeViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> LangActionResult(int id)
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.TopProviderViewModels = await (from lang in providerDbContext.LanguageConfigurations
                                                         join topprov in providerDbContext.TopProviders on lang.Id equals topprov.LangId
                                                         where lang.Id == id
                                                         select new TopProviderViewModel
                                                         {
                                                             BackColor = topprov.BackColor,
                                                             TagName = topprov.TagName,
                                                             Logo = topprov.ImagePath,
                                                             Id = topprov.DataId
                                                         }).ToListAsync();

            homeViewModel.CoreProviderViewModels = await (from lang in providerDbContext.LanguageConfigurations
                                                          join coreprov in providerDbContext.CoreProviders on lang.Id equals coreprov.LangId
                                                          where lang.Id == id
                                                          select new CoreProviderViewModel
                                                          {
                                                              BackColor = coreprov.BackColor,
                                                              TagName = coreprov.TagName,
                                                              Logo = coreprov.ImagePath,
                                                              Text = coreprov.Text,
                                                              Id = coreprov.Id
                                                          }).ToListAsync();

            homeViewModel.FooterText = await (from lang in providerDbContext.LanguageConfigurations
                                              join footer in providerDbContext.FooterInfos on lang.Id equals footer.LangId
                                              where lang.Id == id
                                              select footer.Text).ToListAsync();

            homeViewModel.LanguageId = await (from lang in providerDbContext.LanguageConfigurations
                                              where lang.Id == id
                                              select lang.Id).FirstOrDefaultAsync();

            return Json(homeViewModel);
        }


    }
}
