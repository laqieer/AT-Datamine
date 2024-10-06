-- このluaスクリプトは、MA_01A900_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera003 = SetTemplate("Actor003",110,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor001,"Close")
reserve_eyesync(Actor001,"Close")
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor001,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.5)
set_common_look_at(Actor003,Actor001,1.5)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor001)
 --PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:…そうあろうと<br>つとめる子でしたから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040002")

	change_face(Actor003,"Sad")

	--★★ノワール★★:…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A900_040004")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:騎士様方と異なり<br>剣が得意なわけでもなく
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040005")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
lookat_weight(Actor003,0.8,0.03,0.8,0.2)
keep_delay_ik_lookat(Actor003,Actor002, "J_Head", 0.8)
-- ▲直接出力

	--★★ギネマウア★★:気持ちだけは負けぬよう張り詰めていました<br>負傷も多く、休む暇なく駆け続けていました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040006")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:キズはキラーズ因子で補填され…<br>ゆえにこの子はいつも平気でいられた
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040007")


	--★★ギネマウア★★:自分がボロボロであることにも気づかず──
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネマウア★★:継承者のキラーズであり<br>私のマスターでもあり続けた…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040009")


	--★★ギネマウア★★:それも…<br>キラーズ因子の消耗が激しい原因でしょう
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:…聖遺物化の兆候が頻繁に現れ始めています<br>この休眠状態もそのひとつ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Pain")

	--★★ギネマウア★★:あと２度…いえ１度、戦いに赴けば<br>因子はすり減り、ギネヴィアは…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040013")

	open_select_window_tag(Actor003,"Normal","MA_01A900_040015","MA_01A900_040016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ノワール★★:…まだ戦うべき敵が残っています
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A900_040018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:継承者様の強さは<br>重々承知のつもりです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040019")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:最後の戦いに向け<br>キラーズが不可欠なことも。ですが…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:…休ませてあげましょう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A900_040022")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:…良いのですか？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040023")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ノワール★★:ギネヴィアに無理をさせてきた<br>俺の責任です
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A900_040024")

	goto Block1end

::Block1end::
	change_face(Actor002,"Pain")

	--★★ギネマウア★★:…彼女を<br>つれて行かないでください
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:彼女のキラーズとしてもそうですが<br>なによりもひとりの姉として
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040028")


	--★★ギネマウア★★:ギネヴィアがボロボロになっていくのを<br>見ていられなくなってきています
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネマウア★★:始めは…彼女のやりたいこと、選んだ道<br>それを応援したく思っていました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040030")


	--★★ギネマウア★★:でも今の私は、世界やバルバロイがどうなるか<br>気にならないわけではありませんが
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040031")


	--★★ギネマウア★★:この子を忘れたくない
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040032")

-- ▼直接出力
lookat_weight(Actor003,0.8,0.03,0.8,0.2)
keep_delay_ik_lookat(Actor003,Actor002, "J_Head", 0.8)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:俺もです
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A900_040034")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:継承者が今まで託されてきたものすべてを<br>なかったことにしてしまう…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040035")


	--★★ギネマウア★★:だから言い出せなかった
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:あなたが継承者であるかぎり…<br>学園にいる以上、出来ない相談ではありますが
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040038")


	--★★ギネマウア★★:私の心としては<br>偽りのない本音としては
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040039")

-- ▼直接出力
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Pain")

	--★★ギネマウア★★:もうギネヴィアを<br>託したくない
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_040040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
