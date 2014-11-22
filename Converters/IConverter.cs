using System;

namespace CustomConverters
{
    interface IConverter
    {
        String ConvertInput(String sourse);

        String ConvertOutput(String sourse);
    }
}
