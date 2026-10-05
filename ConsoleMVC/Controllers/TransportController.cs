using ConsoleMVC.Model;
using ConsoleMVC.Views;

namespace ConsoleMVC.Controller
{
    class TransportController
    {
        private Transport transport;
        private TranspotView transportView;

        public TransportController()
        {
			transportView = new TranspotView();
			transport = new Transport(transportView.Kilometes, transportView.TimeOfDay);
            transportView.MinPrice = transport.CalculateMinPrice();
            transportView.ShowMinPrice();
        }
    }
}
