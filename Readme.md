# How to check a SwitchColumn by a single tap


<p>This example illustrates how to implement SwichColumn value changing using a single tap (not a usual approach with opening an editing row).</p>


<h3>Description</h3>

<p>Data object should implement the INotifyPropertyChanged interface and send notifications on the required boolean property changing. The ItemsSource collection should be the&nbsp;DevExpress.Mobile.Core.Containers.BindingList&lt;T&gt; collection to notify the GridControl about changes inside data objects.</p>

<br/>


