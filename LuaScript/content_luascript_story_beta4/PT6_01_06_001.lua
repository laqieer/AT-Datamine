-- このluaスクリプトは、PT6_01_06_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
change_face(Actor002,"Anger")
-- ▲直接出力
-- ▼直接出力
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
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:…兄さん、決めたよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:モルガン先生を助けに行くなら<br>私もついていく
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:マルディサントの力になってあげたいし<br>ブライアンさんとも話がしたいし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:止めるつもりはないさ<br>そう言いだすと思ってたからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_06_0010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ありがとう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010009")

-- ▼直接出力
wait_time(0.5) 
--setup_small_camera_end()
CloseTalkWindow()
change_face(Actor002,"Sad")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
wait_time(1.8)
change_face(Actor002,"Sad")
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ねえ。本当に<br>ブライアンさんと戦わないといけないのかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010010")


	--★★ディナタン★★:もしブライアンさんが武器を向けてきたら<br>兄さんはどうするの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010011")

	open_select_window_tag(Actor001,"Normal","PT6_01_06_0010012","PT6_01_06_0010013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのときは…戦うしかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_06_0010015")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:そんなはっきり言えるなんて<br>兄さんは強いね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私は考えるだけで怖いよ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん<br>俺だって戦うことを望んでいるわけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_06_0010018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:モルガン先生の救出するために<br>戦わなくちゃならないなら、戦うってだけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_06_0010019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:覚悟はしておかないと<br>いけないんだってことはわかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_06_0010021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、戦わずに済むなら…その方法があるなら…<br>俺はそっちを選びたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01_06_0010022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん、そうだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010023")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:少し、安心した…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:今から考えてても仕方ないよね<br>とりあえず、ご飯いっぱい食べて元気つけとこ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010026")


	--★★ディナタン★★:兄さんも食べて食べて！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT6_01_06_0010027")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
