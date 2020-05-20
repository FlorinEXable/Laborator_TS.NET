using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhoto;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Photos
{
    public class IndexModel : PageModel
    {
        InterfacePhotoClient ipc = new InterfacePhotoClient();
        public List<PhotoDTO> Photos { get; set; }
        public IndexModel()
        {
            Photos = new List<PhotoDTO>();
        }
        public async Task OnGetAsync()
        {
            var photos = await ipc.GetNamesAsync();
            foreach(var item in photos)
            {
                PhotoDTO pd = new PhotoDTO();
                pd.Cale = item;
                pd.DataCreare = await ipc.GetDataCreariiAsync(item);
                pd.Eveniment = await ipc.GetEvenimentAsync(item);
                pd.Loc = await ipc.GetLocAsync(item);
                pd.Persoane = await ipc.GetPersoaneAsync(item);
                Photos.Add(pd);
            }
        }
    }
}