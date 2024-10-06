-- このluaスクリプトは、PT3_01C_12_002.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:おはよー、ノワールくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT3_01C_12_002001")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、フレン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_002002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フレン★★:あのさ<br>ルーシャスくんって、このあとどうなるのかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT3_01C_12_002003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ルーシャス？<br>俺たちの今後の戦いに協力してくれるって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_002004")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:そうじゃなくて！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT3_01C_12_002005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:あっ…そうじゃないわけじゃないか
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT3_01C_12_002006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どっちなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_002007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:えっとさ。ルーシャスくんと<br>また学園で一緒に勉強できたりするのかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT3_01C_12_002008")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:ルーシャスが学園に戻ってくるかってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_002009")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、どうだろうな<br>あいつ、気まぐれだからなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_12_002010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:そうだよね<br>気まぐれで意地っ張りでヒネくれ者だもんね…
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT3_01C_12_002011")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:（そこまで言ってないけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT3_01C_12_002012")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
