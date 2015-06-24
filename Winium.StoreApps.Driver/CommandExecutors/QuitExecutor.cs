﻿namespace Winium.StoreApps.Driver.CommandExecutors
{
    internal class QuitExecutor : CommandExecutorBase
    {
        #region Methods

        protected override string DoImpl()
        {
            if (!this.Session.ActualCapabilities.DebugCodedUi)
            {
                this.Session.CommandForwarder.ForwardCommand(this.ExecutedCommand);
                this.Session.Deployer.Close();
            }

            return this.JsonResponse();
        }

        #endregion
    }
}