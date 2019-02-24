using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class ProviderDb
    {
        public static void Seed(ProviderDbContext providerdbcontext, RoleManager<IdentityRole> roleManager)
        {
            if (!providerdbcontext.Roles.Any())
            {
                string[] roleNames = Enum.GetNames(typeof(RoleType));
                foreach (string role in roleNames)
                {
                    IdentityRole identityRole = new IdentityRole(role);
                    roleManager.CreateAsync(identityRole).GetAwaiter().GetResult();
                    // mozarDbContext.Roles.Add(identityRole);
                }
                // mozarDbContext.SaveChanges();
            }
            if (!providerdbcontext.LanguageConfigurations.Any())
            {
                LanguageConfiguration azeConfig = new LanguageConfiguration()
                {
                    LangName = "aze",
                    PhotoPath = "if_Flag_of_Azerbaijan_96205.png"
                };

                LanguageConfiguration rusConfig = new LanguageConfiguration()
                {
                    LangName = "rus",
                    PhotoPath = "if_Flag_of_Russia_96241.png"

                };

                LanguageConfiguration engConfig = new LanguageConfiguration()
                {
                    LangName = "eng",
                    PhotoPath = "if_Flag_of_United_Kingdom_96354.png"

                };
                List<LanguageConfiguration> languageConfigurations = new List<LanguageConfiguration>() { azeConfig, rusConfig, engConfig };

                for (int i = 0; i < languageConfigurations.Count; i++)
                {
                    providerdbcontext.LanguageConfigurations.Add(languageConfigurations[i]);
                    providerdbcontext.SaveChanges();
                }


                IndexPhoto mainLogo = new IndexPhoto()
                {
                    PhotoPath = "emanat.png",
                    LangId = 1
                };

                IndexPhoto secondLogo = new IndexPhoto()
                {
                    PhotoPath = "Info-I-Logo.png",
                    LangId = 1
                };

                IndexPhoto mainLogo1 = new IndexPhoto()
                {
                    PhotoPath = "emanat.png",
                    LangId = 2
                };

                IndexPhoto secondLogo1 = new IndexPhoto()
                {
                    PhotoPath = "Info-I-Logo.png",
                    LangId = 2
                };

                IndexPhoto mainLogo2 = new IndexPhoto()
                {
                    PhotoPath = "emanat.png",
                    LangId = 3
                };

                IndexPhoto secondLogo2 = new IndexPhoto()
                {
                    PhotoPath = "Info-I-Logo.png",
                    LangId = 3
                };
                List<IndexPhoto> indexPhotos = new List<IndexPhoto>()
                {
                    mainLogo,secondLogo,mainLogo1,secondLogo1,mainLogo2,secondLogo2
                };

                for (int i = 0; i < indexPhotos.Count; i++)
                {
                    providerdbcontext.IndexPhotos.Add(indexPhotos[i]);
                    providerdbcontext.SaveChanges();
                }

                FooterInfo azeInfo = new FooterInfo()
                {
                    Text = "Müştəri xidmətləri: 012 404 48 88",
                    LangId = 1
                };

                FooterInfo rusInfo = new FooterInfo()
                {
                    Text = "Служба поддержки клиентов: 012 404 48 88",
                    LangId = 2
                };

                FooterInfo engInfo = new FooterInfo()
                {
                    Text = "Customer service: 012 404 48 88",
                    LangId = 3
                };
                List<FooterInfo> footerInfos = new List<FooterInfo>()
                {
                    azeInfo,rusInfo,engInfo
                };

                for (int i = 0; i < footerInfos.Count; i++)
                {
                    providerdbcontext.FooterInfos.Add(footerInfos[i]);
                    providerdbcontext.SaveChanges();
                }

            }
            if (!providerdbcontext.TopProviders.Any())
            {
                TopProvider socarAze = new TopProvider()
                {
                    ImagePath = "socar.png",
                    BackColor = "rgb(5,72,153)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 1

                };

                TopProvider azersuAze = new TopProvider()
                {
                    ImagePath = "AZERSU logo.png",
                    BackColor = "rgb(29,135,198)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 1
                };

                TopProvider azercellAze = new TopProvider()
                {
                    ImagePath = "Azercell_logo.png",
                    BackColor = "rgb(192, 178, 250)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 2
                };

                TopProvider bakcellAze = new TopProvider()
                {
                    ImagePath = "bakcell.png",
                    BackColor = "rgb(257,77,97)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 2
                };

                TopProvider narAze = new TopProvider()
                {
                    ImagePath = "230x96narlogo.png",
                    BackColor = "rgb(176, 4, 62)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 2
                };

                TopProvider azerishiqAze = new TopProvider()
                {
                    ImagePath = "bes.png",
                    BackColor = "rgb(193, 188, 36)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 1
                };

                TopProvider megaInsuranceAze = new TopProvider()
                {
                    ImagePath = "ec46dae9-e637-498d-adc5-e12034b5b34e.jpg",
                    BackColor = "rgb(223, 31, 148)",
                    TagName = "a",
                    LangId = 1
                };



                TopProvider socarRus = new TopProvider()
                {
                    ImagePath = "socar.png",
                    BackColor = "rgb(5,72,153)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 10
                };

                TopProvider azersuRus = new TopProvider()
                {
                    ImagePath = "AZERSU logo.png",
                    BackColor = "rgb(29,135,198)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 10
                };

                TopProvider azercellRus = new TopProvider()
                {
                    ImagePath = "Azercell_logo.png",
                    BackColor = "rgb(192, 178, 250)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 11
                };

                TopProvider bakcellRus = new TopProvider()
                {
                    ImagePath = "bakcell.png",
                    BackColor = "rgb(257,77,97)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 11
                };

                TopProvider narRus = new TopProvider()
                {
                    ImagePath = "230x96narlogo.png",
                    BackColor = "rgb(176, 4, 62)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 11
                };

                TopProvider azerishiqRus = new TopProvider()
                {
                    ImagePath = "bes.png",
                    BackColor = "rgb(193, 188, 36)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 10
                };

                TopProvider megaInsuranceRus = new TopProvider()
                {
                    ImagePath = "ec46dae9-e637-498d-adc5-e12034b5b34e.jpg",
                    BackColor = "rgb(223, 31, 148)",
                    TagName = "a",
                    LangId = 2
                };


                TopProvider socarEng = new TopProvider()
                {
                    ImagePath = "socar.png",
                    BackColor = "rgb(5,72,153)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 19
                };

                TopProvider azersuEng = new TopProvider()
                {
                    ImagePath = "AZERSU logo.png",
                    BackColor = "rgb(29,135,198)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 19
                };

                TopProvider azercellEng = new TopProvider()
                {
                    ImagePath = "Azercell_logo.png",
                    BackColor = "rgb(192, 178, 250)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 20
                };

                TopProvider bakcellEng = new TopProvider()
                {
                    ImagePath = "bakcell.png",
                    BackColor = "rgb(257,77,97)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 20
                };

                TopProvider narEng = new TopProvider()
                {
                    ImagePath = "230x96narlogo.png",
                    BackColor = "rgb(176, 4, 62)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 20
                };

                TopProvider azerishiqEng = new TopProvider()
                {
                    ImagePath = "bes.png",
                    BackColor = "rgb(193, 188, 36)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 19
                };

                TopProvider megaInsuranceEng = new TopProvider()
                {
                    ImagePath = "ec46dae9-e637-498d-adc5-e12034b5b34e.jpg",
                    BackColor = "rgb(223, 31, 148)",
                    TagName = "a",
                    LangId = 3
                };


                List<TopProvider> TopProviders = new List<TopProvider>()
                {
                    socarAze, azersuAze, azercellAze, bakcellAze, narAze, azerishiqAze, megaInsuranceAze,
                    socarRus,azersuRus,azercellRus,bakcellRus,narRus,azerishiqRus,megaInsuranceRus,
                    socarEng,azersuEng,azercellEng, bakcellEng, narEng, azerishiqEng, megaInsuranceEng
                };

                for (int i = 0; i < TopProviders.Count; i++)
                {
                    providerdbcontext.TopProviders.Add(TopProviders[i]);
                    providerdbcontext.SaveChanges();
                }
            }
            if (!providerdbcontext.CoreProviders.Any())
            {
                CoreProvider utilityAze = new CoreProvider()
                {
                    ImagePath = "communal.png",
                    Text = "Kommunal ödənişlər",
                    BackColor = "rgb(23,92,179)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 1
                };
                CoreProvider mobileOperatorsAze = new CoreProvider()
                {
                    ImagePath = "hand-with-smartphone-and-wireless-internet.png",
                    Text = "Mobil operatorlar",
                    BackColor = "rgb(253,169,6)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 2
                };
                CoreProvider bankServicesAze = new CoreProvider()
                {
                    ImagePath = "bill.png",
                    Text = "Bank xidmətləri",
                    BackColor = "rgb(61,30,121)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 3
                };
                CoreProvider governmentAze = new CoreProvider()
                {
                    ImagePath = "university-with-a-flag.png",
                    Text = "Dövlət və bələdiyyə",
                    BackColor = "rgb(177,29,165)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 4
                };
                CoreProvider tvAze = new CoreProvider()
                {
                    ImagePath = "monitor.png",
                    Text = "TV",
                    BackColor = "rgb(68,128,28)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 5
                };
                CoreProvider internetAze = new CoreProvider()
                {
                    ImagePath = "Wifi.png",
                    Text = "İnternet",
                    BackColor = "rgb(239,58,37)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 6
                };
                CoreProvider homePhoneAze = new CoreProvider()
                {
                    ImagePath = "old-telephone-ringing.png",
                    Text = "Telefon",
                    BackColor = "rgb(49,137,188)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 7
                };
                CoreProvider entertainmentAze = new CoreProvider()
                {
                    ImagePath = "gamepad.png",
                    Text = "Əyləncə və oyunlar",
                    BackColor = "rgb(179,30,69)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 8
                };
                CoreProvider eWalletAze = new CoreProvider()
                {
                    ImagePath = "wallet-filled-money-tool.png",
                    Text = "E-pulqabı",
                    BackColor = "rgb(180,116,48)",
                    TagName = "a",
                    LangId = 1,
                    DataId = 9
                };
                CoreProvider utilityRus = new CoreProvider()
                {
                    ImagePath = "communal.png",
                    Text = "Коммунальные платежи",
                    BackColor = "rgb(23,92,179)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 1
                };
                CoreProvider mobileOperatorsRus = new CoreProvider()
                {
                    ImagePath = "hand-with-smartphone-and-wireless-internet.png",
                    Text = " Сотовые операторы",
                    BackColor = "rgb(253,169,6)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 2
                };
                CoreProvider bankServicesRus = new CoreProvider()
                {
                    ImagePath = "bill.png",
                    Text = " Банковские услуги ",
                    BackColor = "rgb(61,30,121)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 3
                };
                CoreProvider governmentRus = new CoreProvider()
                {
                    ImagePath = "university-with-a-flag.png",
                    Text = " Государственные и муниципальные платежи",
                    BackColor = "rgb(177,29,165)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 4
                };
                CoreProvider tvRus = new CoreProvider()
                {
                    ImagePath = "monitor.png",
                    Text = "TВ",
                    BackColor = "rgb(68,128,28)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 5
                };
                CoreProvider internetRus = new CoreProvider()
                {
                    ImagePath = "Wifi.png",
                    Text = "Интернет",
                    BackColor = "rgb(239,58,37)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 6
                };
                CoreProvider homePhoneRus = new CoreProvider()
                {
                    ImagePath = "old-telephone-ringing.png",
                    Text = "Tелефон",
                    BackColor = "rgb(49,137,188)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 7
                };
                CoreProvider entertainmentRus = new CoreProvider()
                {
                    ImagePath = "gamepad.png",
                    Text = "Развлечения и игры",
                    BackColor = "rgb(179,30,69)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 8
                };
                CoreProvider eWalletRus = new CoreProvider()
                {
                    ImagePath = "wallet-filled-money-tool.png",
                    Text = " E-кошелек ",
                    BackColor = "rgb(180,116,48)",
                    TagName = "a",
                    LangId = 2,
                    DataId = 9
                };

                CoreProvider utilityEng = new CoreProvider()
                {
                    ImagePath = "communal.png",
                    Text = " Utility payments ",
                    BackColor = "rgb(23,92,179)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 1
                };
                CoreProvider mobileOperatorsEng = new CoreProvider()
                {
                    ImagePath = "hand-with-smartphone-and-wireless-internet.png",
                    Text = " Mobile operators ",
                    BackColor = "rgb(253,169,6)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 2
                };
                CoreProvider bankServicesEng = new CoreProvider()
                {
                    ImagePath = "bill.png",
                    Text = " Bank services ",
                    BackColor = "rgb(61,30,121)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 3
                };
                CoreProvider governmentEng = new CoreProvider()
                {
                    ImagePath = "university-with-a-flag.png",
                    Text = " State and municipality payments ",
                    BackColor = "rgb(177,29,165)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 4
                };
                CoreProvider tvEng = new CoreProvider()
                {
                    ImagePath = "monitor.png",
                    Text = " TV ",
                    BackColor = "rgb(68,128,28)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 5
                };
                CoreProvider internetEng = new CoreProvider()
                {
                    ImagePath = "Wifi.png",
                    Text = " Internet ",
                    BackColor = "rgb(239,58,37)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 6
                };
                CoreProvider homePhoneEng = new CoreProvider()
                {
                    ImagePath = "old-telephone-ringing.png",
                    Text = " Phone ",
                    BackColor = "rgb(49,137,188)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 7
                };
                CoreProvider entertainmentEng = new CoreProvider()
                {
                    ImagePath = "gamepad.png",
                    Text = " Entertainment and Games ",
                    BackColor = "rgb(179,30,69)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 8
                };
                CoreProvider eWalletEng = new CoreProvider()
                {
                    ImagePath = "wallet-filled-money-tool.png",
                    Text = " E-Wallet ",
                    BackColor = "rgb(180,116,48)",
                    TagName = "a",
                    LangId = 3,
                    DataId = 9
                };

                List<CoreProvider> coreProviders = new List<CoreProvider>()
                {
                    utilityAze,mobileOperatorsAze,bankServicesAze,governmentAze,tvAze,internetAze,homePhoneAze,entertainmentAze,eWalletAze,
                    utilityRus,mobileOperatorsRus,bankServicesRus,governmentRus,tvRus,internetRus,homePhoneRus,entertainmentRus,eWalletRus,
                    utilityEng,mobileOperatorsEng,bankServicesEng,governmentEng,tvEng,internetEng,homePhoneEng,entertainmentEng,eWalletEng
                };

                for (int i = 0; i < coreProviders.Count; i++)
                {
                    providerdbcontext.CoreProviders.Add(coreProviders[i]);
                    providerdbcontext.SaveChanges();
                }
            }
            if (!providerdbcontext.GroupProviders.Any())
            {
                GroupProvider azeriGazAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeriqaz.png",
                    CoreProviderId = 1,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azersSuAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "AZERSU logo.png",
                    CoreProviderId = 1,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azerIshiqAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bes.png",
                    CoreProviderId = 1,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider rahatYashamAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "rahatyasham.png",
                    CoreProviderId = 1,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azeriGazRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeriqaz.png",
                    CoreProviderId = 10,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azersSuRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "AZERSU logo.png",
                    CoreProviderId = 10,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azerIshiqRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bes.png",
                    CoreProviderId = 10,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider rahatYashamRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "rahatyasham.png",
                    CoreProviderId = 10,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azeriGazEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeriqaz.png",
                    CoreProviderId = 19,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azersSuEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "AZERSU logo.png",
                    CoreProviderId = 19,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider azerIshiqEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bes.png",
                    CoreProviderId = 19,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };

                GroupProvider rahatYashamEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "rahatyasham.png",
                    CoreProviderId = 19,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 1
                };


                GroupProvider azercellAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azercell.png",
                    CoreProviderId = 2,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider bakcellAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "200x41 red-logo.png",
                    CoreProviderId = 2,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider narAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "230x96narlogo.png",
                    CoreProviderId = 2,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider naxtelAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "naxtel4gmobile.png",
                    CoreProviderId = 2,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider azercellRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azercell.png",
                    CoreProviderId = 11,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider bakcellRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "200x41 red-logo.png",
                    CoreProviderId = 11,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider narRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "230x96narlogo.png",
                    CoreProviderId = 11,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider naxtelRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "naxtel4gmobile.png",
                    CoreProviderId = 11,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider azercellEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azercell.png",
                    CoreProviderId = 20,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider bakcellEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "200x41 red-logo.png",
                    CoreProviderId = 20,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider narEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "230x96narlogo.png",
                    CoreProviderId = 20,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider naxtelEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "naxtel4gmobile.png",
                    CoreProviderId = 20,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 2
                };

                GroupProvider accessbankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "accessbank.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider agbankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "agbank.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider amrahbankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "logo_az1.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider atabankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "atabank.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider azerturkAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azer_turk7.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };


                GroupProvider bankofbakuAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bankofbaku.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider bankrespublikaAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bankrespublika.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider expressAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "express.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider irshadAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "logo_irshad1.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider kapitalbankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "kapitalbank.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider rabitabankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "rabitabank.png",
                    CoreProviderId = 3,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider turanbankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "turanbank.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = true,
                    ProviderCategroyId = 3
                };

                GroupProvider unibankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "unibank.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider xalqbankAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "header.png",
                    CoreProviderId = 3,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };


                GroupProvider accessbankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "accessbank.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider agbankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "agbank.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider amrahbankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "logo_az1.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider atabankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "atabank.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider azerturkRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azer_turk7.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };


                GroupProvider bankofbakuRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bankofbaku.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider bankrespublikaRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bankrespublika.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider expressRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "express.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider irshadRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "logo_irshad1.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider kapitalbankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "kapitalbank.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };



                GroupProvider rabitabankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "rabitabank.png",
                    CoreProviderId = 12,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider turanbankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "turanbank.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = true,
                    ProviderCategroyId = 3
                };

                GroupProvider unibankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "unibank.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider xalqbankRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "header.png",
                    CoreProviderId = 12,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider accessbankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "accessbank.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider agbankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "agbank.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider amrahbankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "logo_az1.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider atabankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "atabank.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider azerturkEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azer_turk7.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };



                GroupProvider bankofbakuEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bankofbaku.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider bankrespublikaEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "bankrespublika.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider expressEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "express.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider irshadEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "logo_irshad1.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider kapitalbankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "kapitalbank.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider rabitabankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "rabitabank.png",
                    CoreProviderId = 21,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider turanbankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "turanbank.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = true,
                    ProviderCategroyId = 3
                };

                GroupProvider unibankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "unibank.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };

                GroupProvider xalqbankEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "header.png",
                    CoreProviderId = 21,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = true,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 3
                };



                GroupProvider taxesAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "taxes.png",
                    CoreProviderId = 4,
                    HasOptions = true,
                    HasSecondaryOptions = true,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 4
                };


                GroupProvider taxesRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "taxes.png",
                    CoreProviderId = 13,
                    HasOptions = true,
                    HasSecondaryOptions = true,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 4
                };


                GroupProvider taxesEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "taxes.png",
                    CoreProviderId = 22,
                    HasOptions = true,
                    HasSecondaryOptions = true,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 4
                };


                GroupProvider ailetvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ailetv.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider albaxtvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "albaxtv.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider alfanettvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ALFANET_TV.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider atvplusAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "atvplus.png",
                    CoreProviderId = 5,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };


                GroupProvider CitylineAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "Cityline.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider cliptvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "cliptv150.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider connecttvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "connect.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider katvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "katv.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider nartvAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "nartv.png",
                    CoreProviderId = 5,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider ailetvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ailetv.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider albaxtvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "albaxtv.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider alfanettvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ALFANET_TV.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider atvplusRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "atvplus.png",
                    CoreProviderId = 14,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider CitylineRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "Cityline.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider cliptvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "cliptv150.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider connecttvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "connect.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider katvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "katv.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider nartvRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "nartv.png",
                    CoreProviderId = 14,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };


                GroupProvider ailetvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ailetv.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider albaxtvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "albaxtv.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider alfanettvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ALFANET_TV.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider atvplusEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "atvplus.png",
                    CoreProviderId = 23,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };


                GroupProvider CitylineEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "Cityline.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider cliptvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "cliptv150.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider connecttvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "connect.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider katvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "katv.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };

                GroupProvider nartvEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "nartv.png",
                    CoreProviderId = 23,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 5
                };


                GroupProvider ailetvinternetAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ailetv.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider alfanetAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "alfanet.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider avirtelAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "avirtel.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azeronlineAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeronline.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azeurotelAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeurot_logo.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azincomAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azincom.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider aztelekmAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "aztelekm.png",
                    CoreProviderId = 6,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider CitylineinternetAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "Cityline.png",
                    CoreProviderId = 6,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider ailetvinternetRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ailetv.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider alfanetRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "alfanet.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider avirtelRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "avirtel.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azeronlineRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeronline.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azeurotelRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeurot_logo.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azincomRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azincom.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider aztelekmRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "aztelekm.png",
                    CoreProviderId = 15,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider CitylineinternetRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "Cityline.png",
                    CoreProviderId = 15,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider ailetvinternetEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ailetv.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider alfanetEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "alfanet.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider avirtelEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "avirtel.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azeronlineEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeronline.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6

                };

                GroupProvider azeurotelEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeurot_logo.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azincomEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azincom.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider aztelekmEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "aztelekm.png",
                    CoreProviderId = 24,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider CitylineinternetEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "Cityline.png",
                    CoreProviderId = 24,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 6
                };

                GroupProvider azeurotelphoneAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeurot_logo.png",
                    CoreProviderId = 7,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider catelAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "catel (1).png",
                    CoreProviderId = 7,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider transeurocomAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "transeurocom.png",
                    CoreProviderId = 7,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider azeurotelphoneRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeurot_logo.png",
                    CoreProviderId = 16,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider catelRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "catel (1).png",
                    CoreProviderId = 16,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider transeurocomRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "transeurocom.png",
                    CoreProviderId = 16,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider azeurotelphoneEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "azeurot_logo.png",
                    CoreProviderId = 25,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider catelEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "catel (1).png",
                    CoreProviderId = 25,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };

                GroupProvider transeurocomEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "transeurocom.png",
                    CoreProviderId = 25,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 7
                };


                GroupProvider gameAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "4game.png",
                    CoreProviderId = 8,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider DrWebAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "DrWeb.png",
                    CoreProviderId = 8,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider esetAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ESET_logo.png",
                    CoreProviderId = 8,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };


                GroupProvider kasperskyAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "kaspersky.png",
                    CoreProviderId = 8,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider gameRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "4game.png",
                    CoreProviderId = 17,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider DrWebRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "DrWeb.png",
                    CoreProviderId = 17,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider esetRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ESET_logo.png",
                    CoreProviderId = 17,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };


                GroupProvider kasperskyRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "kaspersky.png",
                    CoreProviderId = 17,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };



                GroupProvider gameEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "4game.png",
                    CoreProviderId = 26,
                    HasOptions = false,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider DrWebEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "DrWeb.png",
                    CoreProviderId = 26,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };

                GroupProvider esetEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "ESET_logo.png",
                    CoreProviderId = 26,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };


                GroupProvider kasperskyEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "kaspersky.png",
                    CoreProviderId = 26,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 8
                };



                GroupProvider azerpayAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "144.jpg",
                    CoreProviderId = 9,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 9
                };

                GroupProvider portmanatAze = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "portmanat.png",
                    CoreProviderId = 9,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 9
                };

                GroupProvider azerpayRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "144.jpg",
                    CoreProviderId = 18,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 9
                };

                GroupProvider portmanatRus = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "portmanat.png",
                    CoreProviderId = 18,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 9
                };
                GroupProvider azerpayEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "144.jpg",
                    CoreProviderId = 27,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 9
                };

                GroupProvider portmanatEng = new GroupProvider()
                {
                    TagName = "a",
                    BackColor = "fff",
                    ImagePath = "portmanat.png",
                    CoreProviderId = 27,
                    HasOptions = true,
                    HasSecondaryOptions = false,
                    HasInput = true,
                    HasSecondaryInput = false,
                    HasAdditionalInput = false,
                    ProviderCategroyId = 9
                };

                List<GroupProvider> groupProviders = new List<GroupProvider>()
                    {
                        azeriGazAze,azersSuAze,azerIshiqAze,rahatYashamAze,
                        azeriGazRus,azersSuRus,azerIshiqRus,rahatYashamRus,
                        azeriGazEng,azersSuEng,azerIshiqEng,rahatYashamEng,
                        azercellAze,bakcellAze,narAze,naxtelAze,
                        azercellRus,bakcellRus,narRus,naxtelRus,
                        azercellEng,bakcellEng,narEng,naxtelEng,
                        accessbankAze,agbankAze,amrahbankAze,atabankAze,
                        azerturkAze,bankofbakuAze,bankrespublikaAze,expressAze,
                        irshadAze,kapitalbankAze,rabitabankAze,
                        turanbankAze,unibankAze,xalqbankAze,
                        accessbankRus,agbankRus,amrahbankRus,atabankRus,
                        azerturkRus,bankofbakuRus,bankrespublikaRus,expressRus,
                        irshadRus,kapitalbankRus,rabitabankRus,
                        turanbankRus,unibankRus,xalqbankRus,
                        accessbankEng,agbankEng,amrahbankEng,atabankEng,
                        azerturkEng,bankofbakuEng,bankrespublikaEng,expressEng,
                        irshadEng,kapitalbankEng,rabitabankEng,
                        turanbankEng,unibankEng,xalqbankEng,taxesAze,taxesRus,taxesEng,
                        ailetvAze,albaxtvAze,alfanettvAze,atvplusAze
                       ,CitylineAze,cliptvAze,connecttvAze,katvAze,nartvAze,
                        ailetvRus,albaxtvRus,alfanettvRus,atvplusRus
                        ,CitylineRus,cliptvRus,connecttvRus,katvRus,nartvRus,
                        ailetvEng,albaxtvEng,alfanettvEng,atvplusEng
                        ,CitylineEng,cliptvEng,connecttvEng,katvEng,nartvEng,
                        ailetvinternetAze,alfanetAze,avirtelAze,azeronlineAze,azeurotelAze,
                        azincomAze,aztelekmAze,CitylineinternetAze,
                        ailetvinternetRus,alfanetRus,avirtelRus,azeronlineRus,azeurotelRus,
                        azincomRus,aztelekmRus,CitylineinternetRus,
                        ailetvinternetEng,alfanetEng,avirtelEng,azeronlineEng,azeurotelEng,
                        azincomEng,aztelekmEng,CitylineinternetEng,
                        azeurotelphoneAze,catelAze,transeurocomAze,
                        azeurotelphoneRus,catelRus,transeurocomRus,
                        azeurotelphoneEng,catelEng,transeurocomEng,
                        gameAze,DrWebAze,esetAze,kasperskyAze,
                        gameRus,DrWebRus,esetRus,kasperskyRus,
                        gameEng,DrWebEng,esetEng,kasperskyEng,
                        azerpayAze,portmanatAze,azerpayRus,portmanatRus,
                        azerpayEng,portmanatEng
                    };
                for (int i = 0; i < groupProviders.Count; i++)
                {
                    providerdbcontext.GroupProviders.Add(groupProviders[i]);
                    providerdbcontext.SaveChanges();
                }
            }
            if (!providerdbcontext.ProviderHeaderInfos.Any())
            {
                ProviderHeaderInfo utilityAzeHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "KOMMUNAL ÖDƏNİŞLƏR",
                    ImgPath = "communal.png",
                    CoreProviderId = 1
                };

                ProviderHeaderInfo utilityRusHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "КОММУНАЛНЫЕ ПЛАТЕЖИ",
                    ImgPath = "communal.png",
                    CoreProviderId = 10
                };

                ProviderHeaderInfo utilityEngHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "UTILITY PAYMENTS",
                    ImgPath = "communal.png",
                    CoreProviderId = 19
                };

                ProviderHeaderInfo mobileAzeProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "MOBIL OPERATORLAR",
                    ImgPath = "hand-with-smartphone-and-wireless-internet.png",
                    CoreProviderId = 2
                };

                ProviderHeaderInfo mobileRusProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "МОБИЛЬНЫЕ ОПЕРАТОРЫ",
                    ImgPath = "hand-with-smartphone-and-wireless-internet.png",
                    CoreProviderId = 11
                };

                ProviderHeaderInfo mobileEngProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "MOBILE OPERATORS",
                    ImgPath = "hand-with-smartphone-and-wireless-internet.png",
                    CoreProviderId = 20
                };

                ProviderHeaderInfo bankAzeProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "BANK XIDMƏTLƏRI",
                    ImgPath = "bill.png",
                    CoreProviderId = 3
                };

                ProviderHeaderInfo bankRusProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = " Банковские услуги ",
                    ImgPath = "bill.png",
                    CoreProviderId = 12
                };

                ProviderHeaderInfo bankEngProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "BANKING SERVICES",
                    ImgPath = "bill.png",
                    CoreProviderId = 21
                };

                ProviderHeaderInfo stateAzeHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Dövlət və bələdiyyə",
                    ImgPath = "university-with-a-flag.png",
                    CoreProviderId = 4
                };

                ProviderHeaderInfo stateRusHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Государственные и муниципальные платежи",
                    ImgPath = "university-with-a-flag.png",
                    CoreProviderId = 13
                };

                ProviderHeaderInfo stateEngHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "State and municipality payments ",
                    ImgPath = "university-with-a-flag.png",
                    CoreProviderId = 22
                };

                ProviderHeaderInfo tvAzeProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "TV",
                    ImgPath = "monitor.png",
                    CoreProviderId = 5
                };

                ProviderHeaderInfo tvRusProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "TВ",
                    ImgPath = "monitor.png",
                    CoreProviderId = 14
                };

                ProviderHeaderInfo tvEngProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "TV",
                    ImgPath = "monitor.png",
                    CoreProviderId = 23
                };

                ProviderHeaderInfo InternetAzeHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "İnternet",
                    ImgPath = "Wifi.png",
                    CoreProviderId = 6
                };

                ProviderHeaderInfo InternetRusHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Интернет",
                    ImgPath = "Wifi.png",
                    CoreProviderId = 15
                };

                ProviderHeaderInfo InternetEngHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "İnternet",
                    ImgPath = "Wifi.png",
                    CoreProviderId = 24
                };

                ProviderHeaderInfo homephoneAzeProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Telefon",
                    ImgPath = "old-telephone-ringing.png",
                    CoreProviderId = 7
                };

                ProviderHeaderInfo homephonerusProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Tелефон",
                    ImgPath = "old-telephone-ringing.png",
                    CoreProviderId = 16
                };

                ProviderHeaderInfo homephoneEngProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Phone ",
                    ImgPath = "old-telephone-ringing.png",
                    CoreProviderId = 25
                };

                ProviderHeaderInfo entertainmentAzeHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Əyləncə və oyunlar",
                    ImgPath = "gamepad.png",
                    CoreProviderId = 8
                };
                ProviderHeaderInfo entertainmentRusHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Развлечения и игры",
                    ImgPath = "gamepad.png",
                    CoreProviderId = 17
                };
                ProviderHeaderInfo entertainmentEngHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "Entertainment and Games ",
                    ImgPath = "gamepad.png",
                    CoreProviderId = 26
                };

                ProviderHeaderInfo ewalletAzeProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = "E-pulqabı",
                    ImgPath = "wallet-filled-money-tool.png",
                    CoreProviderId = 9
                };

                ProviderHeaderInfo ewalletRusProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = " E-кошелек ",
                    ImgPath = "wallet-filled-money-tool.png",
                    CoreProviderId = 18
                };

                ProviderHeaderInfo ewalletEngProviderHeaderInfo = new ProviderHeaderInfo()
                {
                    Text = " E-Wallet ",
                    ImgPath = "wallet-filled-money-tool.png",
                    CoreProviderId = 27
                };
                List<ProviderHeaderInfo> providerHeaderInfos = new List<ProviderHeaderInfo>()
                {
                    utilityAzeHeaderInfo,utilityRusHeaderInfo,utilityEngHeaderInfo,
                    mobileAzeProviderHeaderInfo,mobileRusProviderHeaderInfo,mobileEngProviderHeaderInfo,
                    bankAzeProviderHeaderInfo,bankRusProviderHeaderInfo,bankEngProviderHeaderInfo,
                    stateAzeHeaderInfo,stateRusHeaderInfo,stateEngHeaderInfo,tvAzeProviderHeaderInfo,tvRusProviderHeaderInfo,tvEngProviderHeaderInfo,
                    InternetAzeHeaderInfo,InternetRusHeaderInfo,InternetEngHeaderInfo,
                    homephoneAzeProviderHeaderInfo,homephonerusProviderHeaderInfo,homephoneEngProviderHeaderInfo,
                    entertainmentAzeHeaderInfo,entertainmentRusHeaderInfo,entertainmentEngHeaderInfo,
                    ewalletAzeProviderHeaderInfo,ewalletRusProviderHeaderInfo,ewalletEngProviderHeaderInfo
                };
                for (int i = 0; i < providerHeaderInfos.Count; i++)
                {
                    providerdbcontext.ProviderHeaderInfos.Add(providerHeaderInfos[i]);
                    providerdbcontext.SaveChanges();
                }

            }
            if (!providerdbcontext.ProviderCategories.Any())
            {

                ProviderCategory Utility = new ProviderCategory()
                {
                    Name = "utility"
                };
                ProviderCategory Mobile = new ProviderCategory()
                {
                    Name = "mobile"
                };
                ProviderCategory BankServices = new ProviderCategory()
                {
                    Name = "bank"
                };
                ProviderCategory State = new ProviderCategory()
                {
                    Name = "state"
                };
                ProviderCategory TV = new ProviderCategory()
                {
                    Name = "tv"
                };
                ProviderCategory Internet = new ProviderCategory()
                {
                    Name = "internet"
                };
                ProviderCategory Phone = new ProviderCategory()
                {
                    Name = "phone"
                };
                ProviderCategory Entertainment = new ProviderCategory()
                {
                    Name = "Entertainment"
                };
                ProviderCategory EWallet = new ProviderCategory()
                {
                    Name = "e_wallet"
                };

                List<ProviderCategory> providerCategories = new List<ProviderCategory>()
                {
                    Utility,Mobile,BankServices,State,TV,Internet,Phone,Entertainment,EWallet
                };

                foreach (var item in providerCategories)
                {
                    providerdbcontext.ProviderCategories.Add(item);
                    providerdbcontext.SaveChanges();
                }
            }

        }
    }
}
