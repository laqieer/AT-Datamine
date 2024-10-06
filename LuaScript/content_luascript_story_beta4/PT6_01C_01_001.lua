-- このluaスクリプトは、PT6_01C_01_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010005")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData110122_01_01,CameraAssetBundleName110122_01,CameraPos110122_01_101)
keep_ik_lookat(Actor002,Actor001,"J_Head")
 --lookat_weight(Actor002,0.8,0.5,0.8,0.3,1.0)
lookat_delay_weight(Actor002, {1.0,0,0.8,0.2} , 1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:邪魔するぞ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010006")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(false)
SkipOffsetCamera(Camera001)
Camera002 = setup_small_camera_resetting(Actor002,CharaPos110122_01_003,CameraPos003)
set_animationcontroller(Actor002,"Com_m_SitController","to Sit01_Loop")
lookat_weight_default(Actor002)
set_enable_auto_lookat(Actor002, true)
setup_template_moveobj_110122_01(3,true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ルーシャス？<br>あんたもここで食事をすることがあるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:我が軍もなかなか慌ただしくなってきていてな<br>今日はお抱えの料理人が出張っているのだ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010008")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ、そうなのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ルーシャス★★:辛気臭い顔を見せるな<br>大して美味くもない食事がさらに不味くなる
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:栄光とは、困難を克服した先にあるものだ<br>よく覚えておけ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT6_01C_01_0010013","PT6_01C_01_0010014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ひょっとして…励ましてくれたのか？<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010016")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:他者の心を理解し、慮ってやることは<br>人の上に立つ者としての基本だ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:余はその応用として<br>人の心を掌握する術も学んでいるがな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:なら、教えてくれ<br>俺はあとどれだけの困難を克服すればいい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010020")

-- ▼直接出力
PlayPartVoice("ルーシャス", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ルーシャス★★:もうひとつ教えてやろう
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ルーシャス★★:生きることは戦うことだ<br>栄光を掴んだあとは新たな困難が待っている
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010022")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ルーシャス★★:ほう…<br>このミネストローネだけは評価に値するな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010024")

	PlayAction(Actor002,"to Sit01_RH01")
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:おい、料理人を呼べ<br>話がしたい
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT6_01C_01_0010025")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:振り向けばすぐそこにいるだろ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01C_01_0010026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
