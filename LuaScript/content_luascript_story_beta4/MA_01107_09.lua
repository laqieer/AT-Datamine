-- このluaスクリプトは、MA_01107_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",150,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	Camera002 = SetTemplate("Actor002",125,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera003 = SetTemplate("Actor003",-165,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera004 = SetTemplate("Actor004",80,CharaPos110141_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_001)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
set_camera_nearclip(Camera004,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:………わかった。わかったぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090002")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:マァル？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_090003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★マルディサント★★:キラーズになったあとの姿が<br>ひとによってずいぶん違ぇなって思ってたんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:なんかわかった気がする…その意味<br>あの最強補講で腑に落ちたぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,-80,0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:因子の力が思い出に<br>紐づいてるからなんだな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090006")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:普段の授業でも話半分には聞いたことがあった…<br>因枢分解後のキラーズの姿について
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090007")

	PlayAction(Actor003,"to  Std_Worry")

	--★★マルディサント★★:因子に刻まれた太古の伝説の武器の意匠が<br>随所に残されながらも──
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090009")


	--★★マルディサント★★:キラーズ自身の思い出に刻まれた姿…<br>強く印象に残った姿が反映されやすいんだってよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じゃあ…マルディサントのあの姿は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_090012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Shy")

	--★★マルディサント★★:…──妹と考えてた舞台衣装
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090013")

	change_face(Actor003,"Smile")

	--★★マルディサント★★:黒くてカッケェじゃん？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090015")

-- ▼直接出力
setup_small_camera_start(Camera003)
set_rot(Actor001,{0,120,0})
set_rot(Actor002,{0,100,0})
lookat_weight(Actor001,0.6,0.03,0.7,0)
-- ▲直接出力

	--★★マルディサント★★:…いつかこんなの着て<br>舞台に立とうな～…ってさ、言ってた
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090017")

	open_select_window_tag(Actor001,"Normal","MA_01107_090019","MA_01107_090020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うん<br>よく似合っていると思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_090022")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:たりめーだ。妹と考えたんだ<br>似合わねえわけがねえよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090023")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:見せてやりたかったな<br>へへへ…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ディナタンが着せてくれたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_090026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん………<br>…そう、なるのかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_090027")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:ありがとな、ディーナ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090028")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:そう考えるとすげえ嬉しいや<br>どう考えても嬉しいけどさ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090029")

	goto Block1end

::Block1end::
-- ▼直接出力
change_face(Actor001,"Normal")
set_rot(Actor001,{0,155,0})
set_rot(Actor002,{0,125,0})
lookat_weight(Actor002,0.7,0.03,0.7,0)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:こう考えるとさ<br>『わかる』ってのはイイかもな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★モルガン★★:荷ほどきって<br>どうしてこんなに面倒なのかしらねえ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090033")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:…引っ越しが億劫だからじゃねえの
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090035")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:あ、そうそう言い忘れてた<br>聞いて聞いてえ♪
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090036")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
set_rot(Actor001,{0,-160,0})
turn_chara(Actor002,-170,0.5)
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
change_face(Actor003,"Surprise")
-- ▲直接出力

	--★★モルガン★★:お引越し、や～めたの～
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090037")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★モルガン★★:バルバロイの西進を留めることができたからね<br>一時的ではあるけど…ノワールくんたちのおかげ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090039")


	--★★モルガン★★:もちろん万一のために<br>貴重なものはログレスに退避させたけどね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090040")

	change_face(Actor004,"Smile")

	--★★モルガン★★:グラストンベリーで<br>「いつも」の日々に帰れる子たちもいるし
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090041")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Normal")

	--★★モルガン★★:大切なものって<br>切羽詰まってるとわからなくなるものね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090042")

	change_face(Actor004,"Smile")

	--★★モルガン★★:私もお茶がゆったり飲める場所がなくなるのは<br>さびしかったの、実はね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:…モルガンせんせ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090044")


	--★★モルガン★★:荷ほどき、手伝ってもらうわよ<br>マルディサント
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090045")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
set_enable_auto_lookat_all(true)
set_rot(Actor001,{0,140,0})
set_rot(Actor002,{0,120,0})
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:それ、終わったらさ<br>アタシにも茶の淹れかた教えてくんね？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★モルガン★★:淹れられるでしょ？<br>いっつも分量とか時間とか適当だったけど
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01107_090047")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:ちゃんとさ、おいしいヤツ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:マァルぅ。お勉強できるの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01107_090050")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Finger")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:勉強、大好き
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01107_090052")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
