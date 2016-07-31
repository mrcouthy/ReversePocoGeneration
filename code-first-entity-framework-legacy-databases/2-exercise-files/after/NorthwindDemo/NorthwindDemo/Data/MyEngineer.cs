using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace NorthwindDemo.Data
{
    public partial class Engineer
    {
        partial void InitializePartial()
        {
            ((ObservableCollection<EngineerOrder>) EngineerOrders)
                .CollectionChanged += HandleChange;
        }

        private void HandleChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (EngineerOrder item in e.NewItems)
                {
                    Console.WriteLine("** New engineer order detected for EngineerId: {0}",
                        item.EngineerId);
                }
            }

            if (e.OldItems != null)
            {
                foreach (EngineerOrder item in e.OldItems)
                {
                    Console.WriteLine("** Engineer order {0} for engineer {1}. Action: {2}",
                        item.EngineerOrderId,
                        item.EngineerId,
                        e.Action);
                }
            }

            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                // Do something
            }
        }
    }
}