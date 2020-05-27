using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhoto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Pages.Photos
{
    public class IndexModel : PageModel
    {
        InterfacePhotoClient ipc = new InterfacePhotoClient();
        public List<PhotoDTO> Photos { get; set; } = new List<PhotoDTO>();
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public int NumarPoze { get; set; } = 0;
        public List<string> Caracteristici { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Caracteristica { get; set; }
        public IndexModel()
        {
        }
        public async Task OnGetAsync()
        {
            if(string.Equals(Caracteristica, "All") && string.IsNullOrEmpty(SearchString))
            {
                Photos = new List<PhotoDTO>();
                NumarPoze = 0;
                var photos = await ipc.GetNamesAsync();
                foreach (var item in photos)
                {
                    PhotoDTO pd = new PhotoDTO();
                    pd.Cale = item;
                    pd.DataCreare = await ipc.GetDataCreariiAsync(item);
                    pd.Eveniment = await ipc.GetEvenimentAsync(item);
                    pd.Loc = await ipc.GetLocAsync(item);
                    pd.Persoane = await ipc.GetPersoaneAsync(item);
                    pd.Sters = await ipc.GetNumeAsync(item);
                    NumarPoze++;
                    Photos.Add(pd);
                }
            }
            else if (string.Equals(Caracteristica, "Eveniment") && !string.IsNullOrEmpty(SearchString))
            {
                Photos = new List<PhotoDTO>();
                NumarPoze = 0;
                var photos = await ipc.GetEvenimentListAsync(SearchString);
                foreach (var item in photos)
                {
                    PhotoDTO pd = new PhotoDTO();
                    pd.Cale = item;
                    pd.DataCreare = await ipc.GetDataCreariiAsync(item);
                    pd.Eveniment = await ipc.GetEvenimentAsync(item);
                    pd.Loc = await ipc.GetLocAsync(item);
                    pd.Persoane = await ipc.GetPersoaneAsync(item);
                    pd.Sters = await ipc.GetNumeAsync(item);
                    NumarPoze++;
                    Photos.Add(pd);
                }
            }
            else if (string.Equals(Caracteristica, "Loc") && !string.IsNullOrEmpty(SearchString))
            {
                Photos = new List<PhotoDTO>();
                NumarPoze = 0;
                var photos = await ipc.GetLocListAsync(SearchString);
                foreach (var item in photos)
                {
                    PhotoDTO pd = new PhotoDTO();
                    pd.Cale = item;
                    pd.DataCreare = await ipc.GetDataCreariiAsync(item);
                    pd.Eveniment = await ipc.GetEvenimentAsync(item);
                    pd.Loc = await ipc.GetLocAsync(item);
                    pd.Persoane = await ipc.GetPersoaneAsync(item);
                    pd.Sters = await ipc.GetNumeAsync(item);
                    NumarPoze++;
                    Photos.Add(pd);
                }
            }
            else if (string.Equals(Caracteristica, "Persoane") && !string.IsNullOrEmpty(SearchString))
            {
                Photos = new List<PhotoDTO>();
                NumarPoze = 0;
                var photos = await ipc.GetPersoanaListAsync(SearchString);
                foreach (var item in photos)
                {
                    PhotoDTO pd = new PhotoDTO();
                    pd.Cale = item;
                    pd.DataCreare = await ipc.GetDataCreariiAsync(item);
                    pd.Eveniment = await ipc.GetEvenimentAsync(item);
                    pd.Loc = await ipc.GetLocAsync(item);
                    pd.Persoane = await ipc.GetPersoaneAsync(item);
                    pd.Sters = await ipc.GetNumeAsync(item);
                    NumarPoze++;
                    Photos.Add(pd);
                }
            }
            else if (string.Equals(Caracteristica, "DataCreare") && !string.IsNullOrEmpty(SearchString))
            {
                Photos = new List<PhotoDTO>();
                NumarPoze = 0;
                var photos = await ipc.GetDataCreariiListAsync(SearchString);
                foreach (var item in photos)
                {
                    PhotoDTO pd = new PhotoDTO();
                    pd.Cale = item;
                    pd.DataCreare = await ipc.GetDataCreariiAsync(item);
                    pd.Eveniment = await ipc.GetEvenimentAsync(item);
                    pd.Loc = await ipc.GetLocAsync(item);
                    pd.Persoane = await ipc.GetPersoaneAsync(item);
                    pd.Sters = await ipc.GetNumeAsync(item);
                    NumarPoze++;
                    Photos.Add(pd);
                }
            }
            //else
            //{
            //    Photos = new List<PhotoDTO>();
            //    var photos = await ipc.GetNamesAsync();
            //    foreach (var item in photos)
            //    {
            //        PhotoDTO pd = new PhotoDTO();
            //        pd.Cale = item;
            //        pd.DataCreare = await ipc.GetDataCreariiAsync(item);
            //        pd.Eveniment = await ipc.GetEvenimentAsync(item);
            //        pd.Loc = await ipc.GetLocAsync(item);
            //        pd.Persoane = await ipc.GetPersoaneAsync(item);
            //        Photos.Add(pd);
            //    }
            //}
        }
    }
}