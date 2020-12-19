# Conditional Render Component

It's a simple blazor component that can use different render fragment per condition true or false.

## How to use

```razor
<ConditionalRender Condition="() => true">
    <TrueCondition>
        <h1>True condition!</h1>
    </TrueCondition>
    <FalseCondition>
        <h1>False condition!</h1>
    </FalseCondition>
</ConditionalRender>
```

The property `Condition` is a `Func<bool>` so you can use lambda expression or a method with return type bool:

```c#
public Func<bool> Condition { get; set; }
```

`TrueCondition` and `FalseCondition` tag helpers are properties with same type:

```c#
public RenderFragment TrueCondition { get; set; }
public RenderFragment FalseCondition { get; set; }
```

Each render fragment can be missed:

```razor
<ConditionalRender Condition="() => true">
    <TrueCondition>
        <h1>True condition!</h1>
    </TrueCondition>
</ConditionalRender>
```

or

```razor
<ConditionalRender Condition="() => true">
    <FalseCondition>
        <h1>False condition!</h1>
    </FalseCondition>
</ConditionalRender>
```

Even Condition can be null, in this case it is considered `fase`.

```razor
<ConditionalRender>
    <FalseCondition>
        <h1>False condition!</h1>
    </FalseCondition>
</ConditionalRender>
```

## Demo

![Demo Gif](https://github.com/KevinValmo/ConditionalRender/blob/master/ConditionalRenderComp/wwwroot/img/demo.gif)
