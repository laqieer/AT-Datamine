-- このluaスクリプトは、MA_01C109_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos113011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos113011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_002)
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:突然ごめんね<br>お引越しの手伝いに呼び出しちゃって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア","肯定")
-- ▲直接出力

	--★★ギネマウア★★:なにぶん荷物が多く<br>ふたりだけでは運びきれず困っていました
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C109_120003")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:アーサー…様は<br>「部屋は好きに使え」って言ってたけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:さすがにね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120005")

-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_120006")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:私が王妃じゃなくなったってこと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120007")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサーとの婚約を解消したってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_120008")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:まーねまーね？<br>わたしたちにレンアイ感情なかったし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120009")


	--★★ギネヴィア★★:そもそもわたし<br>おしとやかとは無縁に生きてきちゃったし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力

	--★★ギネヴィア★★:向いてなかったのよ、王妃様なんて<br>遅かれ早かれこうなってたのよ、うんうん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ギネヴィア…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_120012")

-- ▼直接出力
wait_time(1.1)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:お安い御用だよ<br>どんな重い荷物でも任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_120014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力

	--★★ギネヴィア★★:それじゃー<br>そこのクローゼットと化粧台をお願いね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…ほ、本当に重そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_120016")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にししっ♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120017")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネマウア","悩む")
-- ▲直接出力

	--★★ギネマウア★★:私は一足先に引っ越し先に行って<br>部屋を綺麗にしておきます
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01C109_120018")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ありがとうね、ノワール<br>それから…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120020")


	--★★ギネヴィア★★:アーサー…様を責めないであげてね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120021")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:もとはといえばお飾りにもなれなかった<br>わたしが悪いワケだし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でもね<br>あるイミ、気がラクになったんだよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120023")


	--★★ギネヴィア★★:バルバロイとの戦いが終わって<br>平和な世界になったら
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120024")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:自由に世界中を旅してまわれるね、って<br>さっきお姉ちゃんと話してたの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:これからもひとりのマスターとして<br>貴方のために戦うから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:よろしくね、ノワール！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C109_120027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
