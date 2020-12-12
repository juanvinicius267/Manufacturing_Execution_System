using Microsoft.AspNetCore.Http;
using Scania.Br.KD.API.Maxload.Synchronization.Data;
using Scania.Br.KD.API.Maxload.Synchronization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Scania.Br.KD.API.Maxload.Synchronization.Dao
{
    public class MaxloadDao
    {
        private readonly MaxloadContext _context;
        public MaxloadDao(MaxloadContext context)
        {
            this._context = context;
        }

        public List<MaxloadModel> FilterData(string textRead)
        {
            string truckId = "Truck #";
            var type = textRead.GetType();
            textRead = textRead.ToString();
            List<MaxloadModel> maxloadModels = new List<MaxloadModel>();
            MaxloadModel maxload = new MaxloadModel();
            var informacoesFiltradas = textRead.Split(new string[] { "SKU, Qty, Priority", "Truck #;", "\r\n" }, 50000, StringSplitOptions.RemoveEmptyEntries);

            maxload.BatchId = informacoesFiltradas[0];
            for (int i = 1; i < informacoesFiltradas.Length; i++)
            {
                MaxloadModel maxload2 = new MaxloadModel();
                maxload2.BatchId = maxload.BatchId;
                try
                {
                    if (informacoesFiltradas[i].Contains(truckId) == true)
                    {
                        var cont = informacoesFiltradas[i].Split("Truck #");
                        maxload.ContainerNum = Convert.ToInt32(cont[1]);
                    }
                    else
                    {
                        var data = informacoesFiltradas[i].Split(new string[] { "-", ", " }, 8, StringSplitOptions.RemoveEmptyEntries);
                        maxload2.ContainerNum = maxload.ContainerNum;
                        maxload2.Component = data[0];

                        maxload2.MuCode = data[1];
                        maxload2.BoxeNumber = data[2];
                        maxload2.PriorityNumber = Convert.ToInt32(data[3]);
                        maxload2.PriorityNumber2 = Convert.ToInt32(data[4]);
                        maxload2.SavedHour = DateTime.Now;
                        maxloadModels.Add(maxload2);
                    }
                }
                catch (Exception)
                {

                    throw;
                }


            }
            return maxloadModels;
        }

        public string OpenFile(IFormFile file)
        {
            string textRead;
            //Checks if the file is not a null file
            if ((file.Length != null && file.Length > 0) && file.ContentType == "text/plain")
            {
                //Try to open te file 
                using (Stream sr = file.OpenReadStream())
                {
                    int starIndex = 0;
                    int endIndex = Convert.ToInt32(file.Length);
                    Byte[] iListOfByte = new Byte[endIndex];
                    sr.Read(iListOfByte, starIndex, endIndex);
                    string fileName = file.FileName;
                    fileName = fileName.Substring(3);
                    fileName = fileName.Replace("2000-S.Txt", "");
                    textRead = fileName +  System.Text.Encoding.UTF8.GetString(iListOfByte);
                    
                }
            }
            else
            {
                textRead = "";
            }
            return textRead;
        }

        public List<MaxloadModel> Get()
        {
           return _context.Tb_Maxload.ToList();
        }
        public async Task<bool> Set(List<MaxloadModel> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                _context.Tb_Maxload.Add(data[i]);
                _context.SaveChanges();
            }
            
            return true;
        }
    }
}
