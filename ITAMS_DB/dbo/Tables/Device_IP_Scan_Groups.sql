CREATE TABLE [dbo].[Device_IP_Scan_Groups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [device_ip_id] INT NOT NULL, 
    [scan_group_id] INT NOT NULL, 
    CONSTRAINT [FK_Device_IP_Scan_Groups_Device_IPs] FOREIGN KEY (device_ip_id) REFERENCES Device_IPs(Id), 
    CONSTRAINT [FK_Device_IP_Scan_Groups_Scan_Groups] FOREIGN KEY (scan_group_id) REFERENCES Scan_Groups(Id)
)
