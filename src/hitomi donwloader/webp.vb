Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Module webp

    <DllImport("libwebp.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Function WebPDecodeBGRAInto(ByVal data As Byte(), ByVal data_size As Integer, ByVal output_buffer As IntPtr, ByVal output_buffer_size As Integer, ByVal output_stride As Integer) As IntPtr
    End Function
    <DllImport("libwebp.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Function WebPGetInfo(ByVal data As Byte(), ByVal data_size As Integer, <Out> ByRef width As Integer, <Out> ByRef height As Integer) As UInteger
    End Function

    Public Function Webp_to_Png(Data() As Byte) As Bitmap
        Dim width, height As Integer
        WebPGetInfo(Data, Data.Length, width, height)
        Dim bmp As Bitmap = New Bitmap(width, height, PixelFormat.Format32bppArgb)
        Dim bmpData As BitmapData
        bmpData = bmp.LockBits(New Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb)
        WebPDecodeBGRAInto(Data, Data.Length, bmpData.Scan0, bmpData.Stride * bmpData.Height, bmpData.Stride)
        Return bmp
    End Function
End Module
