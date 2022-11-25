﻿using System;

namespace Type
{
    public abstract class Union<T1, T2, T3, T4, T5, T6>
    {
        public abstract void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6);
        public abstract T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6);

        public static explicit operator Union<T1, T2, T3, T4, T5, T6>(T1 value)
            => new Case1(value);
        public static explicit operator Union<T1, T2, T3, T4, T5, T6>(T2 value)
            => new Case2(value);
        public static explicit operator Union<T1, T2, T3, T4, T5, T6>(T3 value)
            => new Case3(value);
        public static explicit operator Union<T1, T2, T3, T4, T5, T6>(T4 value)
            => new Case4(value);
        public static explicit operator Union<T1, T2, T3, T4, T5, T6>(T5 value)
            => new Case5(value);
        public static explicit operator Union<T1, T2, T3, T4, T5, T6>(T6 value)
            => new Case6(value);

        internal sealed class Case1 : Union<T1, T2, T3, T4, T5, T6>
        {
            public readonly T1 item;
            public Case1(T1 item) : base() => this.item = item;
            public override void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6)
                => action1?.Invoke(item);
            public override T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6)
                => func1(item);
        }

        internal sealed class Case2 : Union<T1, T2, T3, T4, T5, T6>
        {
            public readonly T2 item;
            public Case2(T2 item) : base() => this.item = item;
            public override void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6)
                => action2?.Invoke(item);
            public override T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6)
                => func2(item);
        }

        internal sealed class Case3 : Union<T1, T2, T3, T4, T5, T6>
        {
            public readonly T3 item;
            public Case3(T3 item) : base() => this.item = item;
            public override void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6)
                => action3?.Invoke(item);
            public override T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6)
                => func3(item);
        }

        internal sealed class Case4 : Union<T1, T2, T3, T4, T5, T6>
        {
            public readonly T4 item;
            public Case4(T4 item) : base() => this.item = item;
            public override void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6)
                => action4?.Invoke(item);
            public override T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6)
                => func4(item);
        }

        internal sealed class Case5 : Union<T1, T2, T3, T4, T5, T6>
        {
            public readonly T5 item;
            public Case5(T5 item) : base() => this.item = item;
            public override void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6)
                => action5?.Invoke(item);
            public override T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6)
                => func5(item);
        }

        internal sealed class Case6 : Union<T1, T2, T3, T4, T5, T6>
        {
            public readonly T6 item;
            public Case6(T6 item) : base() => this.item = item;
            public override void MatchAction(Action<T1> action1, Action<T2> action2, Action<T3> action3, Action<T4> action4, Action<T5> action5, Action<T6> action6)
                => action6?.Invoke(item);
            public override T MatchFunc<T>(Func<T1, T> func1, Func<T2, T> func2, Func<T3, T> func3, Func<T4, T> func4, Func<T5, T> func5, Func<T6, T> func6)
                => func6(item);
        }
    }
}
