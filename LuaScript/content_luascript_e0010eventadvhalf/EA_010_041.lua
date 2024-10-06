-- このluaスクリプトは、EA_010_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetPlayerTemplate("Actor003",nil,CharaPos116102_01_001,CameraAssetBundleName116102_01,CameraPos116102_01_001)
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
initialize_MA0010023(heroIdshort)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101030200", "content_still_10103020_image", "101030200_StillImage")
load_image("101020270", "content_still_10102027_image", "101020270_StillImage")
load_image("101040010", "content_still_10104001_image", "101040010_StillImage")
load_image("101010210", "content_still_10101021_image", "101010210_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Tyrfing")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_2DOnly("101002","001","101002001")
	Actor003 = InitializePlayerCharacter("Actor003")
	Actor004 = InitializeCharacter_2DOnly("101001","005","101001005")
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:「もう、そばに来ないで」
	Talk(Actor001,"telop","simple","N","EA_010_0410003")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0033")
-- ▲直接出力

	--★★レーヴァテイン★★:めんどくさい嘘
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410004")


	--★★テロップ★★:「自分が痛いのは…平気」
	Talk(Actor001,"telop","simple","N","EA_010_0410005")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力

	--★★レーヴァテイン★★:本当はね
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410006")


	--★★テロップ★★:「もがくほど痛いよ」
	Talk(Actor001,"telop","simple","N","EA_010_0410007")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★レーヴァテイン★★:だから、嬉しかった
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410008")


	--★★レーヴァテイン★★:「一緒に傷つく」だなんて
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410009")

	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:でも、本当にいいの？<br>あなたは今までずっと傷ついてきた
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410010")


	--★★レーヴァテイン★★:また、あの痛みを感じることになるんだよ？
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410011")

	open_select_window_tag(Actor003,"Normal","EA_010_0410013")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:…どうして、そこまで？
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410015")

	goto Block1end

::Block1end::
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_010_0410017")
	if is_select(1) then
		goto Block2_1
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor002,"Smile")

	--★★レーヴァテイン★★:……<%player><br>ありがとう
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410019")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:私もあなたと一緒に笑いたい…
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410020")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0060")
-- ▲直接出力

	--★★レーヴァテイン★★:そのためなら…<br>一緒になら、痛みにも耐えられるよね
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410021")

-- ▼直接出力
show_image("101010150", 0.0, 0.0, 1,false,false)
set_scale_image(20,20)
-- ▲直接出力

	--★★レーヴァテイン★★:<ruby=イミテーション>覚えのある傷痕</ruby>を見て<br><ruby=オリジナル>あなたの痛み</ruby>を思い出して
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","EA_010_0410023")

	open_select_window_tag(Actor003,"Normal","EA_010_0410027")
	if is_select(1) then
		goto Block3_1
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, 0)
wait_time(TIME_ELAPSED)
show_image("101030200", 0.0, 0.0, 0.8,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★テロップ★★:「憶えたそばから<br>忘れていくとしても」
	Talk(Actor001,"telop","simple","N","EA_010_0410031")

	goto Block3end

::Block3end::
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("101020270", 0.0, 0.0, 0.8,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★テロップ★★:「傷痕なら<br>遺せるだろうか」
	Talk(Actor001,"telop","simple","N","EA_010_0410033")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("101040010", 0.0, 0.0, 0.8,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★テロップ★★:「ひとつも失くしたくないのに<br>ひとつしか残せないのなら」
	Talk(Actor001,"telop","simple","N","EA_010_0410035")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
hide_image(0.0)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力

	--★★テロップ★★:「選ぶことしか出来ないのか？」
	Talk(Actor001,"telop","simple","N","EA_010_0410037")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0040")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ティルフィング★★:いいえ
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","EA_010_0410040")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("101010210", 0.0, 0.0, 0.8,true,false)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Tyrfing")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:アナタだけは<br>幾度も傷ついた
	Talk(Actor004,"CHRNAME_TYRFING","simple","N","EA_010_0410042")


	--★★テロップ★★:「汚れなき声を心に刻め」
	Talk(Actor001,"telop","simple","N","EA_010_0410043")


	--★★ティルフィング★★:だから辿れたはずです<br>刻まれたいくつもの傷痕を
	Talk(Actor004,"CHRNAME_TYRFING","simple","N","EA_010_0410044")


	--★★テロップ★★:「我が同胞の叫びを、アナタに」
	Talk(Actor001,"telop","simple","N","EA_010_0410045")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
close_textbox_base()
disableTextBox = true
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101030200", "content_still_10103020_image", "101030200_StillImage")
load_image_preload("101020270", "content_still_10102027_image", "101020270_StillImage")
load_image_preload("101040010", "content_still_10104001_image", "101040010_StillImage")
load_image_preload("101010210", "content_still_10101021_image", "101010210_StillImage")
preload_sound("BGM_ADV_Tyrfing")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101002","001","101002001")
	InitializeCharacter_2DOnly_Preload("101001","005","101001005")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
