using System.Windows;
using Selma.Contracts.Entities;
using Selma.DataAccess;

namespace Selma.App.Controls
{
    /// <summary>
    /// Interaction logic for EditCandidateControl.xaml
    /// </summary>
    public partial class EditCandidateControl
    {
        private readonly ICandidateInfoRepository _repository;

        public EditCandidateControl()
        {
            InitializeComponent();

            _repository = new CandidateInfoRepository();
        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {
            var document = DataContext as CandidateInfo;

            _repository.Update(document);
        }

        private void ButtonDelete_OnClick(object sender, RoutedEventArgs e)
        {
            var document = DataContext as CandidateInfo;

            _repository.Delete(document.FirstName, document.LastName);
        }
    }
}
