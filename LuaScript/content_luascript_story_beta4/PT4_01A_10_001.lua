-- このluaスクリプトは、PT4_01A_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ランスロット<br>聖杯探索の進捗はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0010002")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:正直に言うと<br>あまり芳しくはない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_10_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ガラハッドやフィエナら<br>銀卓騎士団の協力のもと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_10_0010004")


	--★★ランスロット★★:こちらもパーシヴァルやヴォールスを加え<br>手分けして探しているのだが…なかなかな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_10_0010005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やっぱり<br>そう簡単に見つかるものじゃないよな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだったらローマに動きがないとき<br>俺も聖杯探索を手伝おうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0010007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:いや。ローマを侮るな<br>動きがないとしたら、策かもしれないと疑え
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_10_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:たとえば、ローマ対策班の戦力分散を待ち<br>一気に圧し潰そうとしてくるなどな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_10_0010009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そうか…<br>相手はルーシャスにヴェルナルス大将軍だもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:聖杯の情報は必ず持ち帰る<br>俺を信じてくれ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT4_01A_10_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>信じるよ、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_10_0010012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
