using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject.Models;
using finalProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    public class ProviderController : Controller
    {
        private readonly ProviderDbContext providerDbContext;

        public ProviderController(ProviderDbContext _providerDbContext)
        {
            providerDbContext = _providerDbContext;
        }

        public async Task<IActionResult> Index(int id)
        {

            ProviderViewModel providerViewModel = new ProviderViewModel();

            providerViewModel.HeaderViewModels = await (from core in providerDbContext.CoreProviders
                                                  join headinfo in providerDbContext.ProviderHeaderInfos on core.Id equals headinfo.CoreProviderId
                                                  where core.Id == id
                                                  select new HeaderViewModel
                                                  {
                                                      Text = headinfo.Text,
                                                      ImgPath = headinfo.ImgPath
                                                  }).ToListAsync();

            providerViewModel.GroupProviderViewModels = await (from core in providerDbContext.CoreProviders
                                                         join groupprv in providerDbContext.GroupProviders on core.Id equals groupprv.CoreProviderId
                                                         where core.Id == id
                                                         select new GroupProviderViewModel
                                                         {
                                                             Id = groupprv.Id,
                                                             TagName = groupprv.TagName,
                                                             ImagePath = groupprv.ImagePath,
                                                             BackColor = groupprv.BackColor,
                                                             LangId = core.LangId
                                                         }).ToListAsync();
            int langid = providerViewModel.GroupProviderViewModels.Select(x => x.LangId).FirstOrDefault();
            providerViewModel.HomeButtonText = await (from lang in providerDbContext.LanguageConfigurations
                join home in providerDbContext.HomeButtonTexts on lang.Id equals home.LangId
                where lang.Id == langid
                select home.Text).FirstOrDefaultAsync();
            return View(providerViewModel);
        }
    }
}