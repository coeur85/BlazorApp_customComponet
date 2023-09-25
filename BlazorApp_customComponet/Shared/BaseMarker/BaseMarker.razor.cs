using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp_customComponet.Shared.BaseMarker
{
    public partial class BaseMarker
    {
        private bool rdio_officePicDisable;
        private bool drp_staticImagesDisable;
        private bool fileuploadDisable;


        private void OfficeImageChange(ChangeEventArgs e)
        {
            drp_staticImagesDisable = true;
            fileuploadDisable = true;
        }
        private void StaticImageChange(ChangeEventArgs e)
        {
            fileuploadDisable = true;
            drp_staticImagesDisable = false;
        }
        private void CustomeImageChange(ChangeEventArgs e)
        {
            fileuploadDisable = false;
            drp_staticImagesDisable = true;
        }

    }
}
