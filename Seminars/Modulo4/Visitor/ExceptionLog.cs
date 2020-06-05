namespace Directos.Module4.Visitor
{
    public class ExceptionLog
    {
        public ExceptionLog(string appName, Exception exception)
        {
            this.SetLeve(exception);
            this.SetMessage(message);
            string context = exception;
        }

        private void SetLevel(Exception exception)
        {
            if (exception is WarningException) {
                this.level = 'warning';
                return;
            }
            
            if(exception is ErrorException) {
                this.level = 'error';
                return;
            } 
            
            this.level = 'critical';
        }

        private void SetMessage(string appName, Exception exception)
        {
            if (exception is WarningException) {
                this.message = appName + '.warning_exception';
                return;
            }
            
            if(exception is ErrorException) {
                this.message = appName + '.error_exception';
                return;
            }
            
            this.message = appName + '.exception';
        }
    }
}