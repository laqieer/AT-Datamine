-- このluaスクリプトは、MA_01B900_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("MA01B9000701", "content_still_10102009_image", "101020090_StillImage")
load_image("MA01B9000701_2", "content_still_10102009_image", "101020090_StillImage")
load_image("MA01B9000702", "content_still_10102010_image", "101020100_StillImage")
load_image("MA01B9000702_2", "content_still_10102010_image", "101020100_StillImage")
show_image("MA01B9000701", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115081)
	Actor001 = InitializeCharacter_2DOnly("101009","002","101009002")
	Actor002 = InitializeCharacter_2DOnly("101010","001","101010001")
	Actor003 = InitializeCharacter_2DOnly("101010","003","101010003")
	Actor004 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor005 = InitializeCharacter_2DOnly("101028","001","101028001")
	Actor006 = InitializeCharacter_2DOnly("101036","001","101036001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()


	--★★アーサー★★:「はじめまして<br>最低の格好だな」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("MA01B9000702", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ランスロット_2★★:『妖精殺し』探索の任<br>是非このランスロットに！
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01B900_070004")


	--★★アーサー★★:「不躾で不作法、騎士には到底似合わん<br>何のためにここまで参った？」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070005")


	--★★ランスロット_2★★:円卓の騎士になるために
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01B900_070007")


	--★★アーサー★★:「つまみ出せ<br>円卓も今は満席でな」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070008")


	--★★ランスロット_2★★:ここで待つと誓ったんだ！
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01B900_070010")


	--★★アーサー★★:「誓った、誰に？」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070011")


	--★★ランスロット_2★★:家族に！！
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01B900_070013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("MA01B9000701_2", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★アーサー★★:「…その誓いも無用の長物」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070014")


	--★★アーサー★★:「どうせ間もなく終わりは来る<br>俺が終わらせることになるやもしれぬ」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070015")


	--★★アーサー★★:「妖精も消えた。奇跡は起こらん<br>もはや生も学園も続くのは惰性でしかない」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070016")


	--★★アーサー★★:「去れ。<dot>最低騎士</dot>」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070017")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("MA01B9000702_2", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ランスロット_2★★:………席を空ければいいのか？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01B900_070019")


	--★★アーサー★★:「円卓の騎士に挑むか？」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070020")


	--★★ランスロット_2★★:<ruby=あなた>王</ruby>に挑むのは？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","N","MA_01B900_070022")

	open_select_window_tag(Actor001,"Normal","MA_01B900_070023","MA_01B900_070024","MA_01B900_070025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺よりトガってるじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_070027")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前が学園に来たときも<br>似たようなトガり具合だったろう…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_070028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はずっとあんたの背中を<br>追いかけてたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_070030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:先走ったな、俺を置いて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_070032")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:あの時は目の前のことしか<br>目に入らなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_070034")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:焦っていたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_070035")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドとも似ているな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_070037")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:…お爺様の本心を聞き出し<br><ruby=みんな>銀卓騎士</ruby>と同じ景色を見たいと願った
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_070038")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:置き去りにされたのかもしれないという絶望は<br>誰しも同じものを追いかけさせるな
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_070040")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:俺はその問いに<br>喜んで聞き返した
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_070042")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:「喜んで」──…なんと？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_070043")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:………さて？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_070044")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:アーサー
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_070045")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力

	--★★アーサー★★:なんだったかな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_070046")


	--★★アーサー★★:思い出しておくよ<br>X日後までに
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01B900_070047")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★アーサー★★:「本当に」
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070049")

	change_face(Actor003,"Surprise")

	--★★ランスロット_2★★:え…？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","MA_01B900_070051")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★アーサー★★:「<ruby=おれ>王</ruby>を殺してくれるのか」	
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01B900_070053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("MA01B9000701", "content_still_10102009_image", "101020090_StillImage")
load_image_preload("MA01B9000701_2", "content_still_10102009_image", "101020090_StillImage")
load_image_preload("MA01B9000702", "content_still_10102010_image", "101020100_StillImage")
load_image_preload("MA01B9000702_2", "content_still_10102010_image", "101020100_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115081)
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	InitializeCharacter_2DOnly_Preload("101010","003","101010003")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	InitializeCharacter_2DOnly_Preload("101028","001","101028001")
	InitializeCharacter_2DOnly_Preload("101036","001","101036001")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110071_01)
end
