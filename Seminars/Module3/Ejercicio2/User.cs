namespace Directos.Module3.Ejercicio2
{
    public class User
    {
        private int id;
        private int insurance;
        private int nationality;

        public User(int id, string insurance, string nationality)
        {
            this.id = id;
            this.insurance = insurance;
            this.nationality = nationality;
        }

        public int Id()
        {
            return this.id;
        }

        //Calcula el precio del seguro de coche para los que actualmente tienen seguros y son españoles
        public int CalculateInsurance()
        {
            //it has insurance
            if(this.insurance != "") {
                if (this.nationality == "Spain") {
                    int value = 100;
                    //it has some discount
                    if (this.insurance == "axa") {
                        value -= 50;
                    } else if (this.insurance == "mapfre"){
                        value -= 30;
                    }

                    return value;
                } else {
                    throw UserCalculateInsuranceException.FromNationality();
                }
            } else {
                throw UserCalculateInsuranceException.FromInsurance();
            }
        }
    }
}