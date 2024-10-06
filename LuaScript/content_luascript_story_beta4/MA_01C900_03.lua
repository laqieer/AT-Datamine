-- このluaスクリプトは、MA_01C900_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
turn_lookat_position(Actor001,CharaPos005[1],CharaPos005[2],CharaPos005[3],0.0)
-- ▲直接出力
-- ▼直接出力
turn_lookat_position(Actor002,CharaPos002[1],CharaPos002[2],CharaPos002[3],0.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:伝説や妖精、GSに頼らず<br>人として生きていく…ねぇ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030002")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:今更そんなこと言われてもって思わねえか？<br>こっちは散々戦ってきてんのによ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030004")

	open_select_window_tag(Actor001,"Normal","MA_01C900_030005","MA_01C900_030006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだよな<br>ずっとこれしかないと思ってきたのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_030008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイと戦うためには<br>GSして、力を得るしかないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_030009")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:ああ、そうだ<br>…そうじゃなきゃ、誰がこんな真似
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも…アーサーの考えもわかる気がするんだ<br>俺だって、最初は動揺した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイと戦うためとはいえ<br>仲間を武器にするなんて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_030013")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:けど、そのうち慣れてったろ？<br>みんなそうしてきたじゃねぇか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030014")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:オレだって、バルバロイをぶっ倒す方法が<br>ほかにあればGSに頼ったりしねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030016")


	--★★モルドレッド★★:…あいつは本来戦場に立たなくていいヤツだ<br>ほかより少しキラーズ因子が多かっただけで
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030017")

	change_face(Actor002,"Sad")

	--★★モルドレッド★★:そういうヤツがGSして、キラーズになって戦って<br>――それで何人も死んでる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030019")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:…バルバロイは許せねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:だがキラーズやバイブスを使い潰す<br>無能な王はもっと許せねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030023")

	change_face(Actor002,"Sad")

	--★★モルドレッド★★:ずっとそう思ってた…けどよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030024")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力

	--★★モルドレッド★★:いちばんそう思ってたのはオレじゃなくて<br>きっとあのヤロウだったんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:…まぁ、だからなんだって話だけどよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030026")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:モルドレッド…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_030027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★モルドレッド★★:…チッ。なんかむしゃくしゃしてきたぜ<br>その辺でバルバロイでも狩ってくるか<br>?
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C900_030028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
