import win32com.client

prog_id = "COMServer.Server"
com_object = win32com.client.Dispatch(prog_id)

# Now you can call methods or access properties of the COM+ object
result = com_object.ComputePi()
print(result)