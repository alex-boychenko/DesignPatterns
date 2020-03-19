using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    public abstract class Handler
    {
        private Handler _next;

        public Handler(Handler handler)
        {
            _next = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            if (DoHandle(httpRequest))
                return;

            if (_next != null)
                _next.Handle(httpRequest);
        }

        public abstract bool DoHandle(HttpRequest httpRequest);
    }
}
