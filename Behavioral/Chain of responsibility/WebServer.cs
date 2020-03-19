using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    public class WebServer
    {
        private Handler _handler;
        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            _handler.Handle(httpRequest);
        }
    }
}
