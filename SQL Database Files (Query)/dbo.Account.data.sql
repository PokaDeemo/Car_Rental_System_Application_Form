SET IDENTITY_INSERT [dbo].[Account] ON
INSERT INTO [dbo].[Account] ([AccountID], [AccountUsername], [AccountPassword], [AccountEmail], [AccountRole]) VALUES (17, N'Tester', N'1234', N'Tester@gmail.com', N'Employee')
INSERT INTO [dbo].[Account] ([AccountID], [AccountUsername], [AccountPassword], [AccountEmail], [AccountRole]) VALUES (18, N'Freeman', N'1234', N'Freeman@gmail.com', N'Admin')
SET IDENTITY_INSERT [dbo].[Account] OFF
