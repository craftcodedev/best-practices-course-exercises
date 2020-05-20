namespace Directos.Module3.Ejercicio3
{
    public class ExceptionLog
    {
        public ExceptionLog(string appName, Exception exception)
        {
            string level;
            string message;
            string context = exception;

            if (exception is WarningException) {
                level = 'warning';
                message = appName + '.warning_exception';
            } else if(exception is ErrorException) {
                level = 'error';
                message = appName + '.error_exception';
            } else {
                level = 'critical';
                message = appName + '.exception';
            }
        }
    }
}