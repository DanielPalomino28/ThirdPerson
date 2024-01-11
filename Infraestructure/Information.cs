using System.Xml.Linq;
using WebApi.Models;

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
            ThirdPersn datosThirdPerson = thirdpersons.Find(t => t.documentNumber == documentNumber);            
            return datosThirdPerson;
        }

        public List<ThirdPersn> GetAllThirdPersons()
        {
            return thirdpersons;
        }
        

        public void Update(ThirdPersn thirdperson)
        {
            var location = thirdpersons.FindIndex(t => t.documentNumber == t.documentNumber);
            thirdpersons[location] = thirdperson;
        }

        public void Delete(string documentNumber)
        {
            var thirdperson = thirdpersons.Find(t =>t.documentNumber == documentNumber);
            thirdpersons.Remove(thirdperson);
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
