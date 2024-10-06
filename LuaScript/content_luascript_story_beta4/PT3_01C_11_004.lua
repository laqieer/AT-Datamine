-- このluaスクリプトは、PT3_01C_11_004.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:あ、イゾルデ…体調は大丈夫か？<br>休みはちゃんと取れてるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_004002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:モルガン先生がいなくなって以来<br>イゾルデは療養院で働きづめだから心配でさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_004003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:私は別にどこも悪くないし<br>毎晩キチンと眠れているわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01C_11_004004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★イゾルデ★★:お前は、私のことよりも自分の心配をするべきよ<br>ルーシャスを救出に行く準備は進んでいるの？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01C_11_004005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、うん、それはなんとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_004006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:…本当かしら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01C_11_004007")

	change_face(Actor002,"Normal")

	--★★イゾルデ★★:でも、本当だとしたら<br>余計に頑張らなくてはね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01C_11_004008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_004009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:帰って来たとき<br>多少なりともお前たちは怪我をしているでしょう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01C_11_004010")


	--★★イゾルデ★★:その治療のためよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","PT3_01C_11_004011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、迷惑をかける
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_004012")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
