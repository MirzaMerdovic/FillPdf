using System.Windows;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.App.Controls
{
    /// <summary>
    /// Interaction logic for AddCandidate.xaml
    /// </summary>
    public partial class AddCandidateControl
    {
        private readonly ICandidateInfoRepository _repository;

        public AddCandidateControl()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            var document = DataContext as CandidateInfo;

            _repository.Create(document);
        }
    }
}