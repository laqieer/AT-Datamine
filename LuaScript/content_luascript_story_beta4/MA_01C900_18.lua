-- このluaスクリプトは、MA_01C900_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110181_01","110181_01_h")
Include("content_adv_advsmall_110181_01","Template110181_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110181_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110181_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110181_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110181_01,CameraPos110181_01_006)
	InitializeTemplateRandomCamera110181_01()
	InitializeTemplate110181_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110181)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:カムランの丘は<br>アーサーにとってなにか重要な土地なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_180002")


	--★★ノワール★★:なにもない丘陵地帯だと思ったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_180003")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:なにもないからじゃないかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:なにもないから拠点を作りやすいと考えた<br>ウワサでは大きな橋を建造しているとも聞くよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180005")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:橋だって？<br>あのあたりにそんな大きな川なんてあったかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_180006")


	--★★トリスタン★★:川を渡るための橋じゃないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180007")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:高架橋なんだ<br>ブリテン中に兵を自由に行き来させるためのね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:その名も虐殺の橋
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180009")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだって！？そんなことが可能なのか？<br>スケールが大きすぎるだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_180011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:アーサー王の…<br>バルバロイの力があれば可能なんじゃない？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180012")


	--★★トリスタン★★:建造用の材料も石材や鉄鉱石じゃなく<br>人間やバルバロイの骸を使っているらしいよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01C900_180013")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★モルドレッド★★:なんだろうと構いやしねえ<br>あのヤロウの墓標にしてやる
	Talk(Actor003,"CHRNAME_MORDRED","speech","L","MA_01C900_180014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110181)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110181_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
