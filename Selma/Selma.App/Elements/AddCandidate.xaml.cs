using System.Windows;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.App.Elements
{
    /// <summary>
    /// Interaction logic for AddCandidate.xaml
    /// </summary>
    public partial class AddCandidate : Window
    {
        private readonly CandidateDataRepository _repository;

        public AddCandidate()
        {
            InitializeComponent();

            _repository = new CandidateDataRepository();
        }

        private void SaveCandidate_OnClick(object sender, RoutedEventArgs e)
        {
            var document = DataContext as CandidateDocument;

            _repository.Create(document);

            Close();
        }
    }
}
