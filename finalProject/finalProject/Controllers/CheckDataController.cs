using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject.Models;
using finalProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Remotion.Linq.Clauses;

namespace finalProject.Controllers
{
    public class CheckDataController : Controller
    {
        private readonly ProviderDbContext providerDbContext;

        public CheckDataController(ProviderDbContext _providerDbContext)
        {
            providerDbContext = _providerDbContext;
        }

        public async Task<IActionResult> Index(int id, int langId)
        {
            CheckDataViewModel checkDataViewModel = new CheckDataViewModel();
            GroupProvider groupProvider = await (from grp in providerDbContext.GroupProviders
                                                 where grp.Id == id
                                                 select new GroupProvider
                                                 {
                                                     HasOptions = grp.HasOptions,
                                                     HasSecondaryOptions = grp.HasSecondaryOptions,
                                                     HasInput = grp.HasInput,
                                                     HasSecondaryInput = grp.HasSecondaryInput,
                                                     HasAdditionalInput = grp.HasAdditionalInput
                                                 }).FirstOrDefaultAsync();

            checkDataViewModel.HasOptions = groupProvider.HasOptions;
            checkDataViewModel.HasSecondaryOptions = groupProvider.HasSecondaryOptions;
            checkDataViewModel.HasSecondaryInput = groupProvider.HasSecondaryInput;
            checkDataViewModel.HasAdditionalInput = groupProvider.HasAdditionalInput;
            checkDataViewModel.ContinueButtonText = await (from lang in providerDbContext.LanguageConfigurations
                                                           join grpvbtntxt in providerDbContext.GroupProviderPageButtonTexts on lang.Id equals grpvbtntxt
                                                               .LangId
                                                           where lang.Id == langId
                                                           select grpvbtntxt.Text
                ).FirstOrDefaultAsync();

            checkDataViewModel.LangId = await (from lang in providerDbContext.LanguageConfigurations
                                               where lang.Id == langId
                                               select lang.Id).FirstOrDefaultAsync();

            checkDataViewModel.CancelButtonText = await (from lang in providerDbContext.LanguageConfigurations
                                                         join grpvbtntxt in providerDbContext.GroupProviderPageButtonTexts on lang.Id equals grpvbtntxt
                                                             .LangId
                                                         where lang.Id == langId
                                                         select grpvbtntxt.Text
                ).LastOrDefaultAsync();

            checkDataViewModel.ProviderName = await (from grp in providerDbContext.GroupProviders
                                                     where grp.Id == id
                                                     select grp.ProviderName).FirstOrDefaultAsync();

            checkDataViewModel.CoreProviderId = await (from core in providerDbContext.CoreProviders
                                                       join grvp in providerDbContext.GroupProviders on core.Id equals grvp.CoreProviderId
                                                       where grvp.Id == id
                                                       select core.Id).FirstOrDefaultAsync();
            if (checkDataViewModel.HasOptions == true)
            {
                checkDataViewModel.FirstOptionLabelText = (from grp in providerDbContext.GroupProviders
                                                           join prvopt in providerDbContext.ProviderOptions on grp.Id equals prvopt.GroupProviderId
                                                           where grp.Id == id
                                                           where prvopt.IsFirstOption == true
                                                           select prvopt.LabelText).FirstOrDefault();

                checkDataViewModel.FirstOptions = await providerDbContext.ProviderOptions.Include(x => x.GroupProvider)
                    .Where(x => x.GroupProviderId == id && x.IsFirstOption == true).Select(x => x.Text).ToListAsync();

            }

            if (checkDataViewModel.HasSecondaryOptions == true)
            {
                checkDataViewModel.SecindOptionLabelText = (from grp in providerDbContext.GroupProviders
                                                            join prvopt in providerDbContext.ProviderOptions on grp.Id equals prvopt.GroupProviderId
                                                            where grp.Id == id
                                                            select prvopt.LabelText).FirstOrDefault();

                checkDataViewModel.SecondOptions = await providerDbContext.ProviderOptions.Include(x => x.GroupProvider)
                    .Where(x => x.GroupProviderId == id && x.IsSecondaryOption == true).Select(x => x.Text).ToListAsync();
            }

            checkDataViewModel.FirstInputModel = await (from grp in providerDbContext.GroupProviders
                                                        join prvadinfo in providerDbContext.ProviderAdditionalInformations on grp.Id equals prvadinfo
                                                            .GroupProviderId
                                                        where grp.Id == id
                                                        select new FirstInputModel
                                                        {
                                                            InputText = prvadinfo.InputText,
                                                            InputValidLength = prvadinfo.FirstInputValidLength
                                                        }).FirstOrDefaultAsync();

            if (checkDataViewModel.HasSecondaryInput == true)
            {
                checkDataViewModel.SecondInputModel = await (from grp in providerDbContext.GroupProviders
                                                             join prvadinfo in providerDbContext.ProviderAdditionalInformations on grp.Id equals prvadinfo
                                                                 .GroupProviderId
                                                             where grp.Id == id
                                                             select new SecondInputModel
                                                             {
                                                                 InputText = prvadinfo.SecondaryInputText,
                                                                 InputValidLength = prvadinfo.SecondaryInputValidLength
                                                             }).FirstOrDefaultAsync();
            }

            if (checkDataViewModel.HasAdditionalInput == true)
            {
                checkDataViewModel.AdditionalInputModel = await (from grp in providerDbContext.GroupProviders
                                                                 join prvadinfo in providerDbContext.ProviderAdditionalInformations on grp.Id equals prvadinfo
                                                                     .GroupProviderId
                                                                 where grp.Id == id
                                                                 select new AdditionalInputModel
                                                                 {
                                                                     InputText = prvadinfo.AdditionalInputText,
                                                                     InputValidLength = prvadinfo.AdditionalInputValidLength
                                                                 }).FirstOrDefaultAsync();
            }

            checkDataViewModel.ImagePath = await (from grp in providerDbContext.GroupProviders
                                                  where grp.Id == id
                                                  select grp.ImagePath).FirstOrDefaultAsync();

            checkDataViewModel.CategoryName = await (from grp in providerDbContext.GroupProviders
                                                     join prvcat in providerDbContext.ProviderCategories on grp.ProviderCategroyId equals prvcat.Id
                                                     where grp.Id == id
                                                     select prvcat.Name).FirstOrDefaultAsync();

            return View(checkDataViewModel);
        }
    }
}