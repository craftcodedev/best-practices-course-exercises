namespace Directos.Modulo1.Logger
{
    class SignUpUserUseCase
    {
        public void Execute()
        {
            //save log
        }
    }

    class CreateCourseUseCase
    {
        public void Execute()
        {
            //save log
        }
    }
}


//https://cloud.google.com/logging/docs/setup/php?hl=es-419
//linea a linea se tiene que definir en las clases para entender que van en el constructor
//var logging = new LoggingClient("projectId");
//agrupa los registros.
//var logger = logging.psrLogger("app-prod");

//logger.info("Hello World");
//logger.error("Oh no");
//logger.warning("warning");