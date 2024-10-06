-- このluaスクリプトは、MA_01A109_905.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",49,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",63,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101038","001","101038001")
	template1()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
        -- 背景移動回転スケール
        local bg = get_object("BG")
        set_pos(bg,{-10,0,10})

        -- 固定モブ移動回転スケール
        local pro = get_object("Pro_1101_45")
        set_pos(pro,{-10,0,10})
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ふたりとも、お疲れ様<br>おかげで助かったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9050002")

	PlayAction(Actor003,"to  Std_No")

	--★★ローラ★★:ううん<br>私たちはなにもしてないよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A109_9050003")

-- ▼直接出力
 --PlayPartVoice("フレン", "挨拶")
-- ▲直接出力

	--★★フレン★★:ねえ、ノワールくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_9050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:ログレスは正しいことをやってるんだよね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_9050006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9050007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん、俺たちは間違ってない<br>これまでも、これからも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9050008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:そうだよね<br>…わかった
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_9050009")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
 --去った方を見ているような感じにする
turn_chara(Actor003, 180, 0)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:あっ、お姉ちゃん、待って！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","MA_01A109_9050010")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力

	--★★ノワール★★:フレン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_9050011")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101038","001","101038001")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
