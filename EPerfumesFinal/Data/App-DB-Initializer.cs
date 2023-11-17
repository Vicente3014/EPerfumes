using EPerfumesFinal.Data.Enums;
using EPerfumesFinal.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
namespace EPerfumesFinal.Data
{
    public class App_DB_Initializer
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var UserManager = service.GetService<UserManager<IdentityUser>>();
            var RoleManager = service.GetService<RoleManager<IdentityRole>>();
            //Adding Roles to DB
            await RoleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await RoleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //Create Admin User
            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            var UserExistsInDb = await UserManager.FindByEmailAsync(admin.Email);
            if (UserExistsInDb is null)
            {
                await UserManager.CreateAsync(admin, "Admin@123");
                await UserManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();
                //Marcas
                if (!context.Marcas.Any())
                {
                    context.Marcas.AddRange(new List<Marca>()
                    {
                        new Marca()
                        {
                            Marca_Name = "Chanel",
                            Marca_Pic_URL = "https://img2.gratispng.com/20180724/agi/kisspng-chanel-logo-fashion-brand-coco-chanel-5b56ec631760c0.1654778815324232670958.jpg"

                        },
                    new Marca()
                    {
                        Marca_Name = "Paco Rabanne",
                        Marca_Pic_URL = "https://brandemia.org/sites/default/files/sites/default/files/monograma_paco_rabanne-antes.jpg"
                    },
                    new Marca()
                    {
                        Marca_Name = "Hugo Boss",
                        Marca_Pic_URL = "https://upload.wikimedia.org/wikipedia/commons/0/00/Hugo_Boss_logo.JPG"
                    },
                    new Marca()
                    {
                        Marca_Name="Dior",
                        Marca_Pic_URL="https://logowik.com/content/uploads/images/christian-dior-new3874.jpg"
                    },
                    new Marca()
                    {
                        Marca_Name="Carolina Herrera",
                        Marca_Pic_URL="https://i.pinimg.com/originals/f7/73/2b/f7732b3ae45a93051ffb76f5e2a8f486.jpg"
                    }

                });
                    context.SaveChanges();

                }
                if (!context.Perfumes.Any())
                {
                    context.Perfumes.AddRange(new List<Perfume>()
                    {
                        new Perfume()
                        {
                            Perfume_Name = "Bleu de Chanel",
                            PerfumeType = Enums.PerfumeType.Homem,
                            PerfumeVersion = Enums.PerfumeVersion.Eau_de_parfum,
                            Perfume_Pic_URL = "https://www.chanel.com/images//t_one/t_fragrance//q_auto:good,f_auto,fl_lossy,dpr_1.2/w_1920/bleu-de-chanel-eau-de-parfum-spray-3-4fl-oz--packshot-default-107360-9518357086238.jpg",
                            Price = 85.00,
                            Tamanho = 50,
                            Marca_ID = 1
                        },
                        new Perfume()
                        {
                            Perfume_Name = "Coco Mademoiselle",
                            PerfumeType = Enums.PerfumeType.Senhora,
                            PerfumeVersion = Enums.PerfumeVersion.Eau_de_parfum,
                            Perfume_Pic_URL = "https://media.douglas.pt/media/image/00/f3/63/31458911625099g0AoBP1wlJHq.jpg",
                            Price = 150.00,
                            Tamanho = 50,
                            Marca_ID=1
                        },
                        new Perfume()
                        {
                            Perfume_Name="Bad Boy",
                            PerfumeType=Enums.PerfumeType.Homem,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_toilette,
                            Perfume_Pic_URL="https://cdn.fragrance.com/images/photos/600x600/336422.jpg",
                            Price=100.00,
                            Tamanho = 100,
                            Marca_ID=5
                        },
                        new Perfume()
                        {
                            Perfume_Name="Good Girl",
                            PerfumeType=Enums.PerfumeType.Senhora,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_parfum,
                            Perfume_Pic_URL="https://s1.kuantokusta.pt/img_upload/produtos_saudebeleza/208369_3_carolina-herrera-good-girl-woman-eau-de-parfum-80ml.jpg",
                            Price=49.95,
                            Tamanho = 30,
                            Marca_ID=5
                        },
                        new Perfume()
                        {
                            Perfume_Name="Alive",
                            PerfumeType=Enums.PerfumeType.Senhora,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_parfum,
                            Perfume_Pic_URL="https://media.douglas.pt/media/image/15/27/27/Hugo_Boss-Alive-BOSS-BOSS_1280x1280.jpg",
                            Price=55.50,
                            Tamanho=30,
                            Marca_ID = 3
                        },
                        new Perfume()
                        {
                            Perfume_Name="Boss Bottled Tonic",
                            PerfumeType=Enums.PerfumeType.Homem,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_toilette,
                            Perfume_Pic_URL="https://i1.perfumesclub.com/grande/95115.jpg",
                            Price=55.50,
                            Tamanho=50,
                            Marca_ID = 3
                        },
                        new Perfume() 
                        {
                            Perfume_Name="J'adore",
                            PerfumeType=Enums.PerfumeType.Senhora,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_Parfum_Infinissime,
                            Perfume_Pic_URL="https://i1.perfumesclub.com/grande/13195.jpg",
                            Price=128.50,
                            Tamanho=100,
                            Marca_ID = 4
                        },
                        new Perfume()
                        {
                            Perfume_Name="Sauvage",
                            PerfumeType=Enums.PerfumeType.Homem,
                            PerfumeVersion=Enums.PerfumeVersion.Elixir,
                            Perfume_Pic_URL="https://s1.kuantokusta.pt/img_upload/produtos_saudebeleza/203426_3_dior-sauvage-man-eau-de-toilette-100ml.jpg",
                            Price=165.00,
                            Tamanho=60,
                            Marca_ID = 4
                        },
                        new Perfume()
                        {
                            Perfume_Name="Invictus",
                            PerfumeType =Enums.PerfumeType.Homem,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_toilette,
                            Perfume_Pic_URL="https://s1.kuantokusta.pt/img_upload/produtos_saudebeleza/80605_3_paco-rabanne-invictus-man-eau-de-toilette-100ml.jpg",
                            Price=61.50,
                            Tamanho=50,
                            Marca_ID = 2
                        },
                        new Perfume()
                        {
                            Perfume_Name="Fame",
                            PerfumeType=Enums.PerfumeType.Senhora,
                            PerfumeVersion=Enums.PerfumeVersion.Eau_de_parfum,
                            Perfume_Pic_URL="https://media.douglas.pt/media/image/3f/27/28/1028059_0.jpg",
                            Price=50.50,
                            Tamanho=30,
                            Marca_ID = 2
                        }
                    });
                    context.SaveChanges();
            }

        }
    }




}
}
