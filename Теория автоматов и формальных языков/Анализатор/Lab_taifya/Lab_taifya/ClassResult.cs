using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_taifya
{

    public enum Err
    {
        NoError, // нет ошибок
        OutOfRange, // выход за границы анализируемой строки
        LetterExpected, // ожидается определенная буква        
        LetterSpaceSemicolonMathOperExpected, //  ожидается определённая буква или пробел или мат.операция, точка с запятой
        LetterSpaceSemicolonOpenbracketMathOperExpected, // ожидается определенная буква или пробел или открывающая скобка или точка с запятой, мат.операция 
        SpaceOpenbracketExpected, //ожидается пробел или открывающая скобка
        SpaceСolonOpenbracketExpected, // ожидается пробел или открывающая скобка или двоеточие
        LetterDigitSpaceUnderscoreСolonOpenbracketExpected, // ожидается буква, цифра, пробел, нижнее подчеркивание, двоеточие или открывающая скобка
        LetterUnderscoreExpected, //  ожидается буква или подчеркивание
        LetterUnderscoreSpaceExpected, //  ожидается буква или подчеркивание или пробел
        LetterDigitUnderscoreMinusSpaceExpected, //  ожидается буква или цифра или подчеркивание или минус или пробел
        LetterDigitUnderscoreSpaceExpected, //  ожидается буква или цифра или подчеркивание или пробел
        LetterDigitUnderscoreExpected, //  ожидается буква или цифра или подчеркивание 
        LetterSpaceCommaExpected, //  ожидается буква или пробел или запятая
        LetterDigitUnderscoreSpaceCommaExpected, //  ожидается буква или подчеркивание или цифра или пробел или запятая
        LetterDigitUnderscoreSpaceCommaDotExpected, //  ожидается буква или подчеркивание или цифра или пробел или запятая или точка
        LetterDigitUnderscoreSpaceCommaOpenbracketExpected, //  ожидается буква или подчеркивание или цифра или пробел или запятая или открывающая скобка
        LetterDigitUnderscoreSpaceColonOpenBracketExpected, // ожидается буква, цифра, подчеркивание, пробел, открывающая скобка
        LetterDigitUnderscoreSpaceSemicolonCloseBracketExpected, // ожидается буква, цифра, подчеркивание, пробел, точка с запятой и закрывающая скобка
        LetterDigitUnderscoreSpaceEquallyExpected, //ожидается буква или подчеркивание или цифра или пробел или запятая или открывающая скобка, матем.операция
        LetterDigitUnderscoreSpaceColonOpenBracketMathOperExpected, //ожидается буква или подчеркивание или цифра или пробел или запятая или равно
        LetterDigitUnderscoreSpaceMinusMark, // ожидается буква, цифра, нижнее подчеркивание, пробел, минус или одинарная кавычка
        DigitExpected, // ожидается цифра
        NotManager, // ожидается не управляющий символ
        LetterDigitUnderscopeMathOperSpaceOpenbracketSemicolon, // ожидается буква, цифра, нижнее подчеркивание, мат операция, пробел, открывающая скобка, точка с запятой
        NotManagerMark, // ожидается не управляющий символ или кавычка
        Equal, // ожидается знак =
        InsignificantZero, // ожидается один символ 0
        LetterMathOperSpaceOpenbracketSemicolon, // ожидается пробел, мат операция, D, M, открывающая скобка или точка с запятой
        DigitMinusPlusExpected, // ожидается цифра, плюс или минус
        DigitClosebracketExpected, // ожидается цифра или закрывающая скобка
        SpaceClosebracket, // ожидется пробел или закрывающая скобка
        DigitSpaceClosebracket, // ожидается цифра, пробел или закрывающая скобка
        LetterDigitUnderscoreSpaceClosebracket, // ожидается буква, цифра, нижнее подчеркивание, пробел или закрыващая скобка
        DigitSpaceMinusExpected, // ожидается цифра или пробел
        DigitSpaceClosebracketCommaExpected, // ожидается цифра или пробел или закрывающая скобка, запятая
        DigitSpaceOpenbracketExpected, //  ожидается цифра или пробел или открывающая скобка
        DigitSpaceSemicolonMathOperEExpected, //  ожидается цифра или пробел или мат.операция или e, точка с запятой
        DigitDotMathOperESemicolonSpaceExpected, // ожидается мат операция, цифры, точка, e, ;, пробел
        DigitSpaceSemicolonMathOperExpected, //  ожидается цифра или пробел или мат.операция, точка с запятой
        DigitSpaceDotSemicolonMathOperEExpected, //  ожидается цифра или пробел или мат.операция или e, точка с запятой, точка
        SpaceExpected, //  ожидается пробел
        LetterDigitUnderscopeSpaceClosebracket, // ожидается буква, цифра, нижнее подчеркивание, пробел или закрывающая скобка
        LetterDigitUnderscopeMinus, // ожидается буква, цифра, нижнее подчеркивание или минус
        SpaceSemicolon, // ожидается пробел или точка с запятой
        SpaceSemicolonMathOperExpected, // ожидается пробел или точка с запятой, мат.операция
        DigitMathOperSemicolonSpace, // ожидается цифра, пробел, мат операция или точка с запятой
        SpaceColonExpected, // ожидается пробел или двоеточие
        SpaceOpenBracketExpected, // ожидается пробел или открывающая скобка
        EquallyExpected, // ожидается равно
        OverflowIdSymbols, //  количество символов в id превышено
        IncorrectId, //  не является зарезервированным словом
        ValueUotOfRange,//значение константы не в диапазоне -32768 -- 32767
        UnrecognizedError, // неизвестная ошибка
        MantissaError, // Количество цифр в мантиссе не может быть больше 15
        DublicateError // Идентификатор не может дублироваться
    }


    // Класс для передачи результата в интерфейс пользователя
    public class ClassResult
    {
        // Хранит позицию ошибки (-1, если все корректно)
        private int _ErrPosition;
        // Хранит ошибку
        private Err _Err;
        // Список идентификаторов
        private static LinkedList<string> _ListOfIds;
        // Список констант
        private static LinkedList<string> _ListOfConst;
        // Конструктор
        public ClassResult(int ErrPosition, Err Err, LinkedList<string> ListOfIds, LinkedList<string> ListOfConst)
        {
            _ErrPosition = ErrPosition;
            _Err = Err;
            _ListOfIds = ListOfIds;
            _ListOfConst = ListOfConst;
        }
        // Свойство к позиции ошибки
        public int ErrPosition
        {
            get
            {
                return _ErrPosition;
            }
        }
        // Свойство к описанию ошибки
        public string ErrMessage
        {
            get
            {
                switch (_Err)
                {
                    case Err.NoError:
                        { return "нет ошибок"; }
                    case Err.OutOfRange:
                        { return "выход за границы анализируемой строки"; }
                    case Err.LetterExpected:
                        { return "ожидается определенная буква"; }
                    case Err.IncorrectId:
                        { return "не может являться зарезервированным словом  WITH, DO, DIV, MOD"; }
                    case Err.LetterSpaceCommaExpected:
                        { return "ожидается буква или пробел или запятая"; }
                    case Err.LetterDigitSpaceUnderscoreСolonOpenbracketExpected:
                        { return "ожидается буква, цифра, пробел, нижнее подчеркивание, двоеточие или открывающая скобка"; }
                    case Err.LetterDigitUnderscoreSpaceCommaDotExpected:
                        { return "ожидается буква или подчеркивание или цифра или пробел или запятая или точка"; }
                    case Err.LetterDigitUnderscoreSpaceColonOpenBracketExpected:
                        { return "ожидается определенная буква, цифра, пробел, открывающая скобка или двоеточие"; }
                    case Err.SpaceOpenbracketExpected:
                        { return "ожидается пробел или открывающая скобка"; }
                    case Err.NotManager:
                        { return "ожидается неуправляющий символ"; }
                    case Err.LetterDigitUnderscopeSpaceClosebracket:
                        { return "ожидается буква, цифра, нижнее подчеркивание, пробел или закрывающая скобка"; }
                    case Err.LetterDigitUnderscopeMathOperSpaceOpenbracketSemicolon:
                        { return "ожидается буква, цифра, нижнее подчеркивание, мат операция, пробел, открывающая скобка, точка с запятой"; }
                    case Err.DigitMathOperSemicolonSpace:
                        { return "ожидается цифра, пробел, мат операция или точка с запятой"; }
                    case Err.LetterDigitUnderscopeMinus:
                        { return "ожидается буква, цифра, нижнее подчеркивание или минус"; }
                    case Err.NotManagerMark:
                        { return "ожидается неуправляющий символ или кавычка"; }
                    case Err.Equal:
                        { return "ожидается знак ="; }
                    case Err.InsignificantZero:
                        { return "ожидается один символ 0"; }
                    case Err.LetterMathOperSpaceOpenbracketSemicolon:
                        { return "ожидается пробел, мат операция, D, M, открывающая скобка или точка с запятой"; }
                    case Err.LetterDigitUnderscoreSpaceClosebracket:
                        { return "ожидается буква, цифра, нижнее подчеркивание, пробел или закрыващая скобка"; }
                    case Err.SpaceSemicolon:
                        { return "ожидается пробел или точка с запятой"; }
                    case Err.DigitSpaceClosebracket:
                        { return "ожидается цифра, пробел или закрывающая скобка"; }
                    case Err.SpaceClosebracket:
                        { return "ожидается пробел или закрывающая скобка"; }
                    case Err.LetterUnderscoreSpaceExpected:
                        { return "ожидается буква или подчеркивание или пробел"; }
                    case Err.DigitDotMathOperESemicolonSpaceExpected:
                        { return "ожидается мат операция, цифры, точка, e, ;, пробел"; }
                    case Err.SpaceСolonOpenbracketExpected:
                        { return "ожидается пробел,открывающая скобка или двоеточие"; }
                    case Err.LetterUnderscoreExpected:
                        { return "ожидается буква или подчеркивание"; }
                    case Err.LetterDigitUnderscoreMinusSpaceExpected:
                        { return "ожидается буква, цифра, подчеркивание, минус или пробел"; }
                    case Err.LetterDigitUnderscoreSpaceSemicolonCloseBracketExpected:
                        { return "ожидается буква, цифра, подчеркивание, пробел, точка с запятой и закрывающая скобка"; }
                    case Err.LetterDigitUnderscoreExpected:
                        { return "ожидается буква, цифра, подчеркивание"; }
                    case Err.LetterSpaceSemicolonMathOperExpected:
                        { return "ожидается определёенная буква или пробел или мат.операция, точка с запятой"; }
                    case Err.LetterSpaceSemicolonOpenbracketMathOperExpected:
                        { return "ожидается определенная буква или пробел или открывающая скобка или точка с запятой, мат.операция"; }
                    case Err.LetterDigitUnderscoreSpaceCommaOpenbracketExpected:
                        { return "ожидается буква или подчеркивание или цифра или пробел или запятая или открывающая скобка"; }
                    case Err.LetterDigitUnderscoreSpaceColonOpenBracketMathOperExpected:
                        { return "ожидается буква или подчеркивание или цифра или пробел или запятая или открывающая скобка, матем.операция"; }
                    case Err.LetterDigitUnderscoreSpaceEquallyExpected:
                        { return "ожидается буква или подчеркивание или цифра или пробел или запятая или равно"; }
                    case Err.DigitExpected:
                        { return "ожидается цифра"; }
                    case Err.DigitMinusPlusExpected:
                        { return "ожидается цифра, минус или плюс"; }
                    case Err.DigitClosebracketExpected:
                        { return "ожидается цифра или закрывающая скобка"; }
                    case Err.DigitSpaceMinusExpected:
                        { return "ожидается цифра, минус или пробел"; }
                    case Err.DigitSpaceClosebracketCommaExpected:
                        { return "ожидается цифра или пробел или закрывающая скобка, пробел"; }
                    case Err.DigitSpaceOpenbracketExpected:
                        { return "ожидается цифра или пробел или открывающая скобка"; }
                    case Err.DigitSpaceSemicolonMathOperEExpected:
                        { return "ожидается цифра или пробел или мат.операция или Е, точка с запятой"; }
                    case Err.DigitSpaceSemicolonMathOperExpected:
                        { return "ожидается цифра или пробел или мат.операция или точка с запятой"; }
                    case Err.DigitSpaceDotSemicolonMathOperEExpected:
                        { return "ожидается цифра или пробел или мат.операция или Е, точка с запятой, точка"; }
                    case Err.SpaceExpected:
                        { return "ожидается пробел"; }
                    case Err.SpaceColonExpected:
                        { return "ожидается пробел или двоеточие"; }
                    case Err.SpaceSemicolonMathOperExpected:
                        { return "ожидается пробел или точка с запятой, мат.операция"; }
                    case Err.SpaceOpenBracketExpected:
                        { return "ожидается пробел или открывающая скобка"; }
                    case Err.EquallyExpected:
                        { return "ожидается знак равно"; }
                    case Err.OverflowIdSymbols:
                        { return "количество символов в идентификаторе превышено"; }
                    case Err.UnrecognizedError:
                        { return "неизвестная ошибка"; }
                    case Err.ValueUotOfRange:
                        { return "значение константы не в диапазоне -32768 -- 32767"; }
                    case Err.MantissaError:
                        { return "количество цифр в мантиссе не может быть больше 15"; }
                    case Err.DublicateError:
                        { return "идентификатор не может дублироваться"; }
                    default:
                        { return "неизвестная ошибка"; }
                }
            }
        }
        // Свойство к списку идентификаторов
        public LinkedList<string> ListOfIds
        {
            get
            {
                return _ListOfIds;
            }
        }
        // Свойство к списку констант
        public LinkedList<string> ListOfConst
        {
            get
            {
                return _ListOfConst;
            }
        }
    }

}
