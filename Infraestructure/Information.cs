using System.Xml.Linq;
using WebApi.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Infraestructure
{
    public class Information
    {
        private static List<ThirdPersn> thirdpersons = new List<ThirdPersn>();
        private static List<DocumentType> documenttypes = new List<DocumentType>();
        private static List<Gender> genders = new List<Gender>();
        private static List<civilStatus> civilstatus = new List<civilStatus>();
        private static List<Doctor> doctors = new List<Doctor>();
        //Métodos de Thirdperson
        public void CreateThirdPerson(ThirdPersn thirdperson)
        {
            thirdpersons.Add(thirdperson);
        }

        public ThirdPersn GetThirdPersnByDocumentNumber(string documentNumber)
        {
            var ThirdPersn = new ThirdPersn();
            ThirdPersn result = thirdpersons.Find(element => element.documentNumber == documentNumber);
            return result;
        }


        public List<ThirdPersn> GetAllThirdPersons()
        {
            if (thirdpersons.Count() == 0)
            {
                var thirdperson1 = new ThirdPersn();
                thirdperson1.firstName = "Scarlett";
                thirdperson1.lastName = "Johansson";
                thirdperson1.documentType = "Pasaporte";
                thirdperson1.documentNumber = "ABC123";
                thirdperson1.birthdate = "1984-11-22";
                thirdperson1.gender = "Femenino";
                thirdperson1.civilStatus = "Casado/a";
                thirdperson1.doctor = "Daniel Palomino";
                thirdperson1.isPatient = "true";
                thirdpersons.Add(thirdperson1);

                var thirdperson2 = new ThirdPersn();
                thirdperson2.firstName = "Tony";
                thirdperson2.lastName = "Stark";
                thirdperson2.documentType = "Cédula de ciudadanía";
                thirdperson2.documentNumber = "4271101";
                thirdperson2.birthdate = "1965-04-04";
                thirdperson2.gender = "Masculino";
                thirdperson2.civilStatus = "Soltero/a";
                thirdperson2.doctor = "";
                thirdperson2.isPatient = "false";
                thirdpersons.Add(thirdperson2);

                var thirdPerson4 = new ThirdPersn();
                thirdPerson4.firstName = "Natasha";
                thirdPerson4.lastName = "Romanoff";
                thirdPerson4.documentType = "Pasaporte";
                thirdPerson4.documentNumber = "ROM007";
                thirdPerson4.birthdate = "1980-06-21";
                thirdPerson4.gender = "Femenino";
                thirdPerson4.civilStatus = "Soltero/a";
                thirdPerson4.doctor = "Daniel Palomino";
                thirdPerson4.isPatient = "true";
                thirdpersons.Add(thirdPerson4);

                var thirdPerson5 = new ThirdPersn();
                thirdPerson5.firstName = "Bruce";
                thirdPerson5.lastName = "Banner";
                thirdPerson5.documentType = "Cédula de ciudadanía";
                thirdPerson5.documentNumber = "BAN123";
                thirdPerson5.birthdate = "1969-12-18";
                thirdPerson5.gender = "Masculino";
                thirdPerson5.civilStatus = "Casado/a";
                thirdPerson5.doctor = "Daniel Gallego";
                thirdPerson5.isPatient = "true";
                thirdpersons.Add(thirdPerson5);

                var thirdPerson6 = new ThirdPersn();
                thirdPerson6.firstName = "Peter";
                thirdPerson6.lastName = "Parker";
                thirdPerson6.documentType = "Pasaporte";
                thirdPerson6.documentNumber = "SPD123";
                thirdPerson6.birthdate = "1998-08-10";
                thirdPerson6.gender = "Masculino";
                thirdPerson6.civilStatus = "Soltero/a";
                thirdPerson6.doctor = "";
                thirdPerson6.isPatient = "false";
                thirdpersons.Add(thirdPerson6);

                var thirdPerson7 = new ThirdPersn();
                thirdPerson7.firstName = "Wanda";
                thirdPerson7.lastName = "Maximoff";
                thirdPerson7.documentType = "Documento Nacional de Identidad";
                thirdPerson7.documentNumber = "WAN456";
                thirdPerson7.birthdate = "1989-05-15";
                thirdPerson7.gender = "Femenino";
                thirdPerson7.civilStatus = "Viudo/a";
                thirdPerson7.doctor = "Daniel Gallego";
                thirdPerson7.isPatient = "true";
                thirdpersons.Add(thirdPerson7);

                var thirdPerson8 = new ThirdPersn();
                thirdPerson8.firstName = "Thor";
                thirdPerson8.lastName = "Odinson";
                thirdPerson8.documentType = "Cédula de Extranjería";
                thirdPerson8.documentNumber = "THO789";
                thirdPerson8.birthdate = "1999-01-01";
                thirdPerson8.gender = "Masculino";
                thirdPerson8.civilStatus = "Soltero/a";
                thirdPerson8.doctor = "Breidis Luna";
                thirdPerson8.isPatient = "true";
                thirdpersons.Add(thirdPerson8);

                var thirdPerson9 = new ThirdPersn();
                thirdPerson9.firstName = "Gamora";
                thirdPerson9.lastName = "Zen Whoberi Ben Titan";
                thirdPerson9.documentType = "Pasaporte";
                thirdPerson9.documentNumber = "GAM456";
                thirdPerson9.birthdate = "2005-09-12";
                thirdPerson9.gender = "Femenino";
                thirdPerson9.civilStatus = "Soltero/a";
                thirdPerson9.doctor = "";
                thirdPerson9.isPatient = "false";
                thirdpersons.Add(thirdPerson9);

                var thirdPerson10 = new ThirdPersn();
                thirdPerson10.firstName = "Steve";
                thirdPerson10.lastName = "Rogers";
                thirdPerson10.documentType = "Documento Nacional de Identidad";
                thirdPerson10.documentNumber = "VIS001";
                thirdPerson10.birthdate = "1989-06-28";
                thirdPerson10.gender = "No binario";
                thirdPerson10.civilStatus = "Casado/a";
                thirdPerson10.doctor = "";
                thirdPerson10.isPatient = "false";
                thirdpersons.Add(thirdPerson10);

                var thirdPerson11 = new ThirdPersn();
                thirdPerson11.firstName = "Groot";
                thirdPerson11.lastName = "";
                thirdPerson11.documentType = "Registro Civil de Nacimiento";
                thirdPerson11.documentNumber = "GRT789";
                thirdPerson11.birthdate = "2020-09-09";
                thirdPerson11.gender = "No binario";
                thirdPerson11.civilStatus = "Soltero/a";
                thirdPerson11.doctor = "Breidis Luna";
                thirdPerson11.isPatient = "true";
                thirdpersons.Add(thirdPerson11);

                var thirdPerson12 = new ThirdPersn();
                thirdPerson12.firstName = "Scott";
                thirdPerson12.lastName = "Lang";
                thirdPerson12.documentType = "Cédula de ciudadanía";
                thirdPerson12.documentNumber = "ANT007";
                thirdPerson12.birthdate = "1979-06-02";
                thirdPerson12.gender = "Masculino";
                thirdPerson12.civilStatus = "Divorciado/a";
                thirdPerson12.doctor = "Daniel Palomino";
                thirdPerson12.isPatient = "true";
                thirdpersons.Add(thirdPerson12);
            }
            return thirdpersons;
        }
        

        public void Update(ThirdPersn thirdperson)
        {
            var thirdpersonDelete = thirdpersons.Find(t => t.documentNumber == thirdperson.documentNumber);
            thirdpersons.Remove(thirdpersonDelete);
            CreateThirdPerson(thirdperson);
            //var locationThirdpersn = thirdpersons.FindIndex(t => t.documentNumber == t.documentNumber);
            //thirdpersons[locationThirdpersn] = thirdpersons.Remove(thirdperson);
        }

        public void Delete(string documentNumber)
        {
            var documentThirdperson = thirdpersons.Find(t => t.documentNumber == documentNumber);
            if (documentThirdperson != null)
            {
                thirdpersons.Remove(documentThirdperson);
            }
        }
        //Método para crear y mostrar lista de géneros
        public List<Gender> GetAllGenders()
        {
            if (genders.Count() == 0)
            {
                var gender1 = new Gender();
                gender1.idGender = "1";
                gender1.genderName = "Masculino";
                genders.Add(gender1);

                var gender2 = new Gender();
                gender2.idGender = "2";
                gender2.genderName = "Femenino";
                genders.Add(gender2);

                var gender3 = new Gender();
                gender3.idGender = "3";
                gender3.genderName = "No binario";
                genders.Add(gender3);
            }
            return genders;
        }
        //Método para crear y mostrar lista de DocumentType
        public List<DocumentType> GetAllDocumentTypes()
        {
            if (documenttypes.Count() == 0)
            {
                var documentType1 = new DocumentType();
                documentType1.idDocumentType = "1";
                documentType1.nameDocumentType = "Tarjeta de identidad";
                documenttypes.Add(documentType1);

                var documentType2 = new DocumentType();
                documentType2.idDocumentType = "2";
                documentType2.nameDocumentType = "Cédula de ciudadanía";
                documenttypes.Add(documentType2);

                var documentType3 = new DocumentType();
                documentType3.idDocumentType = "3";
                documentType3.nameDocumentType = "Cédula de Extranjería";
                documenttypes.Add(documentType3);

                var documentType4 = new DocumentType();
                documentType4.idDocumentType = "4";
                documentType4.nameDocumentType = "Pasaporte";
                documenttypes.Add(documentType4);

                var documentType5 = new DocumentType();
                documentType5.idDocumentType = "5";
                documentType5.nameDocumentType = "Registro Civil de Nacimiento";
                documenttypes.Add(documentType5);

                var documentType6 = new DocumentType();
                documentType6.idDocumentType = "6";
                documentType6.nameDocumentType = "Permiso Especial de Permanencia";
                documenttypes.Add(documentType6);

                var documentType7 = new DocumentType();
                documentType7.idDocumentType = "7";
                documentType7.nameDocumentType = "Documento Nacional de Identidad";
                documenttypes.Add(documentType7);
            }
            return documenttypes;
        }
        //Método para crear y mostrar lista de géneros
        public List<civilStatus> GetAllCivilStatus()
        {
            if (civilstatus.Count() == 0)
            {
                var civilstatus1 = new civilStatus();
                civilstatus1.idcivilStatus = "1";
                civilstatus1.civilStatusName = "Soltero/a";
                civilstatus.Add(civilstatus1);

                var civilstatus2 = new civilStatus();
                civilstatus2.idcivilStatus = "2";
                civilstatus2.civilStatusName = "Casado/a";
                civilstatus.Add(civilstatus2);

                var civilstatus3 = new civilStatus();
                civilstatus3.idcivilStatus = "3";
                civilstatus3.civilStatusName = "Unión libre";
                civilstatus.Add(civilstatus3);

                var civilstatus4 = new civilStatus();
                civilstatus4.idcivilStatus = "4";
                civilstatus4.civilStatusName = "Divorciado/a";
                civilstatus.Add(civilstatus4);

                var civilstatus5 = new civilStatus();
                civilstatus5.idcivilStatus = "5";
                civilstatus5.civilStatusName = "Viudo/a";
                civilstatus.Add(civilstatus5);
            }
            return civilstatus;
        }

        public List<Doctor> GetAllDoctors()
        {
            if (doctors.Count() == 0)
            {
                var doctors1 = new Doctor();
                doctors1.idDoctor = "1";
                doctors1.doctorName = "Daniel Palomino";
                doctors.Add(doctors1);

                var doctors2 = new Doctor();
                doctors2.idDoctor = "2";
                doctors2.doctorName = "Daniel Gallego";
                doctors.Add(doctors2);

                var doctors3 = new Doctor();
                doctors3.idDoctor = "3";
                doctors3.doctorName = "Breidis Luna";
                doctors.Add(doctors3);

            }
            return doctors;
        }
    }
}
