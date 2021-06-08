using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace DocPatientPortal
{
    public class UploadImageFunction
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        #region Constructor
        public UploadImageFunction(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        #endregion

        #region Function UploadImage(folderpath, file)

        public async Task<string> UploadImage(string folderpath, IFormFile file)
        {
            folderpath += Guid.NewGuid().ToString() + "_" + file.FileName;
            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderpath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return "/" + folderpath;
        }
        #endregion



    }
}
