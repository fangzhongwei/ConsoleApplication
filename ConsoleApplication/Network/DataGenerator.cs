using ConsoleApplication.Helper;

public class DataGenerator
{
    public static byte[] generate(int actionType, byte[] data)
    {
        byte[] actionTypeByteArray = ByteHelper.IntToByteArray(actionType);
        byte[] compress = GZipHelper.compress(data);
        byte[] encodeBytes = DESHelper.EncodeBytes(compress, "ABCD1234");
        byte[] dataLengthByteArray = ByteHelper.IntToByteArray(encodeBytes.Length);
        return ByteHelper.combineTowBytes(ByteHelper.combineTowBytes(actionTypeByteArray, dataLengthByteArray), encodeBytes);
    }
}