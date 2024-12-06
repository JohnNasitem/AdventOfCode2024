private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
{
    string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
    Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
    int visitedPositionsCount = 0;

    //try
    //{

    //}
    //catch
    //{
    //    MessageBox.Show("Failed to read file.");
    //    return;
    //}

    stopwatch.Start();

    //Extract the data
    foreach (string line in File.ReadAllLines(fname))
    {

    }

    //Output values
    UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
    UI_VisitedPositionsCount_Tbx.Text = visitedPositionsCount.ToString();
}


/// <summary>
/// Allow drop effect
/// </summary>
/// <param name="sender">Object that called the code</param>
/// <param name="e">Event args</param>
private void UI_DragDrop_Lbl_DragEnter(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy;
    else
        e.Effect = DragDropEffects.None;
}