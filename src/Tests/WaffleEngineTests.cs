﻿using System;
using System.Diagnostics;
using ApprovalTests;
using WaffleGenerator;
using Xunit;
using Xunit.Abstractions;

public class WaffleEngineTests
{
    ITestOutputHelper output;

    public WaffleEngineTests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void TextWaffleSample()
    {
        var text = WaffleEngine.Text(
            paragraphs: 1,
            includeHeading: true);
        Debug.WriteLine(text);
    }

    [Fact]
    public void HtmlWaffleSample()
    {
        var text = WaffleEngine.Html(
            paragraphs: 2,
            includeHeading: true,
            includeHeadAndBody:true);
        Debug.WriteLine(text);
    }

    [Fact]
    public void HtmlWaffleSampleNoHeadAndBodyParam()
    {
        var text = WaffleEngine.Html(
            paragraphs: 2,
            includeHeading: true);
        Debug.WriteLine(text);
    }

    [Fact]
    public void TextWaffleSingle()
    {
        var random = new Random(0);
        var text = WaffleEngine.Text(random, 1, true);
        Approvals.Verify(text);
    }

    [Fact]
    public void Title()
    {
        var random = new Random(0);
        var title = WaffleEngine.Title(random);
        Approvals.Verify(title);
    }

    [Fact]
    public void HtmlWaffleSingle()
    {
        var random = new Random(0);
        var html = WaffleEngine.Html(random, 1, true, false);
        Approvals.Verify(html);
    }
    [Fact]
    public void HtmlWaffleSingleWithHeadAndBody()
    {
        var random = new Random(0);
        var html = WaffleEngine.Html(random, 1, true,true);
        Approvals.Verify(html);
    }

    [Fact]
    public void TextWaffleMultiple()
    {
        var random = new Random(0);
        var text = WaffleEngine.Text(random, 11, true);
        Approvals.Verify(text);
    }

    [Fact]
    public void HtmlWaffleMultiple()
    {
        var random = new Random(0);
        var html = WaffleEngine.Html(random, 11, true, false);
        Approvals.Verify(html);
    }
    [Fact]
    public void HtmlWaffleMultipleWithHeadAndBody()
    {
        var random = new Random(0);
        var html = WaffleEngine.Html(random, 11, true, true);
        Approvals.Verify(html);
    }

    [Fact]
    public void TextWaffleNoHeading()
    {
        var random = new Random(0);
        var text = WaffleEngine.Text(random, 1, false);
        Approvals.Verify(text);
    }

    [Fact]
    public void HtmlWaffleNoHeading()
    {
        var random = new Random(0);
        var html = WaffleEngine.Html(random, 1, true, false);
        Approvals.Verify(html);
    }

    [Fact]
    public void HtmlWaffleNoHeadingWithHeadAndBody()
    {
        var random = new Random(0);
        var html = WaffleEngine.Html(random, 1, true, true);
        Approvals.Verify(html);
    }
}