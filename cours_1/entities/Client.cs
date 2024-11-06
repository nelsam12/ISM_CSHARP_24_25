namespace Cours.Models
{
    public class Client
    {
        private int id;
        private String surnom;
        private String telephone;
        private String adresse;

        public Client()
        {

        }

        public Client(int id, String surnom, String telephone, String adresse)
        {
            this.id = id;
            this.surnom = surnom;
            this.telephone = telephone;
            this.adresse = adresse;
        }

        public int getId()
        {
            return this.id;
        }

        public String getSurnom()
        {
            return this.surnom;
        }

        public String getTelephone()
        {
            return this.telephone;
        }

        public String getAdresse()
        {
            return this.adresse;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setSurnom(String surnom)
        {
            this.surnom = surnom;
        }

        public void setTelephone(String telephone)
        {
            this.telephone = telephone;
        }

        public void setAdresse(String adresse)
        {
            this.adresse = adresse;
        }

        public override string ToString()
        {
            return "Client[" +
                    "id=" + id +
                    ", surnom='" + surnom + '\'' +
                    ", telephone='" + telephone + '\'' +
                    ", adresse='" + adresse + ']';

        }

        public bool equals(Client other)
        {
            if (this == other) return true;
            if (other == null) return false;
            Client client = (Client)other;
            return id == client.id &&
                    Object.Equals(surnom, client.surnom) &&
                    Object.Equals(telephone, client.telephone) &&
                    Object.Equals(adresse, client.adresse);

        }
    }
}