-- このluaスクリプトは、EX_01_01_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_06","110011_06_h")
Include("content_adv_advsmall_110011_06","Template110011_06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_06_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_06_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_06,CameraPos110011_06_017)
	InitializeTemplateRandomCamera110011_06()
	InitializeTemplate110011_06()
-- ▼直接出力
set_enable_auto_lookat_all(false)
DontChangeRandomCamera(true)


Pen = set_object("content_prop_10106006", "10106006_PropModel", true)
on_parent(Pen, Actor001, "Loc_weapon_constrint_R", 0,0,0, 0,0,0)

CameraEX_1 = set_camera({-1.634227,1.329779,-3.02459,-2.021,-216.063,0,21.40307})

CameraEX_2 = set_camera({1.43,0.83,-2.39,-13,50,0,22})

RndCamera001= CameraEX_1
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_TextOnly()
	Actor006 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CameraEX_1)
local sei = 0
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット","肯定3")
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力

	--★★ランスロット★★:それでは学科試験２日目を開始する<br>始め
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EX_01_01_00020002")

-- ▼直接出力
setup_small_camera_start(CameraEX_2)
-- ▲直接出力

	--★★ノワール★★:よし、今日も頑張るぞ
	Talk(Actor001,"CHRNAME_NOIR","mind","N","EX_01_01_00020004")


	--★★第１問★★:バルバロイの生態として<br>正しいものはどれか
	Talk(Actor003,"NPCNAME_0379","mind","N","EX_01_01_00020006")

-- ▼直接出力
PlayActionDirect(Actor001,"to Studying_Stop02")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EX_01_01_00020008","EX_01_01_00020009","EX_01_01_00020010")
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
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、これだろう<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
sei = sei +1
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、これだろう<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020012")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、これだろう<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020012")

	goto Block1end

::Block1end::

	--★★第２問★★:『きょうぼうしょう』の<br>正しい書きかたはどれか
	Talk(Actor004,"NPCNAME_0380","mind","N","EX_01_01_00020014")

-- ▼直接出力
PlayActionDirect(Actor001,"to Studying_Stop02")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EX_01_01_00020016","EX_01_01_00020017","EX_01_01_00020018")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
sei = sei +1
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これは授業でやったような気がするな<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020020")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これは授業でやったような気がするな<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020020")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これは授業でやったような気がするな<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020020")

	goto Block2end

::Block2end::

	--★★第３問★★:バルバロイに憑かれた場合に起こるものとして<br>正しくないものはどれか
	Talk(Actor005,"NPCNAME_0381","mind","N","EX_01_01_00020022")

-- ▼直接出力
PlayActionDirect(Actor001,"to Studying_Stop02")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EX_01_01_00020024","EX_01_01_00020025","EX_01_01_00020026")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の記憶が確かなら、これだ<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020028")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
sei = sei +1
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の記憶が確かなら、これだ<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020028")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の記憶が確かなら、これだ<br>次の問題は…
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020028")

	goto Block3end

::Block3end::

	--★★第４問★★:「魔女」とはどんな存在か答えよ
	Talk(Actor006,"NPCNAME_0382","mind","N","EX_01_01_00020030")

-- ▼直接出力
PlayActionDirect(Actor001,"to Studying_Stop02")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EX_01_01_00020032","EX_01_01_00020033","EX_01_01_00020034")
	if is_select(1) then
		goto Block4_1
	elseif is_select(2) then
		goto Block4_2
	elseif is_select(3) then
		goto Block4_3
	end

::Block4_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふう<br>これで全部終わったみたいだな
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020036")

	goto Block4end

::Block4_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふう<br>これで全部終わったみたいだな
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020036")

	goto Block4end

::Block4_3::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying")
sei = sei +1
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふう<br>これで全部終わったみたいだな
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020036")

	goto Block4end

::Block4end::
-- ▼直接出力
setup_small_camera_start(CameraEX_1)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C109_01_Bell")
wait_time(1.0)
PlayPartVoice("ランスロット","納得")
-- ▲直接出力

	--★★ランスロット★★:そこまで
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EX_01_01_00020039")


	--★★ランスロット★★:試験の結果は後日発表する<br>皆、ご苦労だったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EX_01_01_00020041")

-- ▼直接出力
setup_small_camera_start(CameraEX_2)
-- ▲直接出力
-- ▼直接出力
if sei >= 3 then
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying_Stop02")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:我ながらバッチリだったんじゃないか？<br>結果発表が楽しみだな！
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020043")

-- ▼直接出力
else
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Studying_Stop02")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:結果は後日発表なのか…<br>今日サッパリだったし、見たくないなあ
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EX_01_01_00020045")

-- ▼直接出力
end
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_prop_10106006", "10106006_PropModel", true)
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110011_06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
