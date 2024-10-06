-- このluaスクリプトは、MA_01C201_06.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
	-- 背景移動回転スケール
local bg = get_object("BG")
set_pos(bg,{0,0,24})

	-- 固定モブ移動回転スケール
local pro = get_object("Pro_1101_45")
set_pos(pro,{0,0,24})
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:歴史の授業は得意か？
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:…なんだよ、突然
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_060003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:我がローマとブリテンは領土を巡り<br>長く争いを続けてきた
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:さすがにそれくらいは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_060005")


	--★★ルーシャス★★:歴史ではなく常識問題であったな<br>そして常識はときに覆る
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060006")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ルーシャス★★:まさかローマの次期皇帝たる余が<br>そなたらと手を組むことになるとは
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060007")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力

	--★★ルーシャス★★:現実は奇なるものだ<br>不可能と思ったことも可能になる
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:人間とバルバロイの共存ですら<br>不可能とは言い切れないのかもしれん
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060009")

	open_select_window_tag(Actor001,"Normal","MA_01C201_060010","MA_01C201_060011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Anger")

	--★★ノワール★★:バルバロイとの共存…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_060013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:おっと、そう睨むな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060014")

	change_face(Actor002,"Normal")

	--★★ルーシャス★★:余は可能性の話をしているだけだ<br>民を統べる者は先を見据えねばならぬ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:それが最善のものであるなら<br>ここで決断することはひとつの務めであろう
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:人間とバルバロイの共存か<br>それも考える必要があるのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_060018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ルーシャス★★:…！
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060020")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:もっとも、共存といえば聞こえは良いが<br>両者の立場は対等ではない
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060022")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:その先に待つのが武器などいらぬ世界なのか<br>武器を持つことを許されぬ世界なのか
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060023")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:余に権利があるのならば<br>民に危害が及ぶ可能性のある選択などせんがな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060025")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:人がバルバロイという強靭な種と混ざり合い<br>愛や生死、飢餓や病という概念を超越する
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:たとえばそういった形の共存もあるだろう<br>あやつの望みがそうかは知らぬがな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:だが、その選択が民のためになるのであれば<br>己の手を汚すことも辞さぬのが王というもの
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサーも…そう思っているんだろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_060031")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:あやつがまだ王であるならば、あるいは?
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C201_060032")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
