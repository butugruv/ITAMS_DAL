CREATE TABLE [dbo].[Device_IP_Scan_Groups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeviceIpId] INT NOT NULL, 
    [ScanGroupId] INT NOT NULL, 
    CONSTRAINT [FK_Device_IP_Scan_Groups_Device_IPs] FOREIGN KEY ([DeviceIpId]) REFERENCES Device_IPs(Id), 
    CONSTRAINT [FK_Device_IP_Scan_Groups_Scan_Groups] FOREIGN KEY ([ScanGroupId]) REFERENCES Scan_Groups(Id)
)
