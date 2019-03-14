import { AbpDemoThreeTemplatePage } from './app.po';

describe('AbpDemoThree App', function() {
  let page: AbpDemoThreeTemplatePage;

  beforeEach(() => {
    page = new AbpDemoThreeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
