-- このluaスクリプトは、MA_01104_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	Camera002 = SetTemplate("Actor002",80,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
load_image("MA011041301", "content_still_10101002_image", "101010020_StillImage")
off_active(Actor002) -- マルディサント非表示
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
on_camera(Camera001)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:………サボっちゃった。授業
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130002")

	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:…留守番、していなきゃ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130003")


	--★★ディナタン★★:良い子で……待っていようよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130005")


	--★★？？？★★:「なんと情けない！<br>道化しか下せぬとは！」
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01104_130007")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:！？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130008")


	--★★？？？★★:「ああっ、貴方は見るに堪えない！」
	Talk(Actor003,"CHRNAME_NAMELES","speech","L","MA_01104_130009")


	--★★ディナタン★★:…声奥から…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130010")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6) 
wait_time(0.6)
show_image("MA011041301", 0.0, 0.0, 0.6,true,false)
wait_time(1.0)
fadein(0,0,0,1.0, 0.6)
-- ▲直接出力

	--★★マルディサント★★:「名乗り出てその体たらく<br>目も当てられない！」
	Talk(Actor002,"NPCNAME_0127","simple","N","MA_01104_130012")


	--★★ディナタン★★:わ…っ
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","MA_01104_130013")


	--★★マルディサント★★:「私がさがすは、黒き楯の冒険を引き継ぐ者！巨悪を断つ騎士様は何処か！？」
	Talk(Actor002,"NPCNAME_0127","simple","N","MA_01104_130015")


	--★★ディナタン★★:わぁ…
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","MA_01104_130017")

-- ▼直接出力
on_active(Actor002) -- マルディサント表示
DontChangeRandomCamera(true)
setup_small_camera_start()
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6) 
wait_time(0.6)
hide_image(0.6)
wait_time(1.0)
fadein(0,0,0,1.0, 0.6)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:…あ
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130019")


	--★★ディナタン★★:はっ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130020")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Pain")

	--★★マルディサント★★:…ゲホッ、ゲホッ！ゲフンゲフン！！ンッ、ンンッ！…コホンッ
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130021")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:………ォオイ
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:は、はいっ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130024")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:ナニ見てんだよ…っ！
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130026")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ディナタン★★:あ、あの、ごめんなさい…！<br>声が聞こえて…それで…、ごめんなさい…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130027")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★マルディサント★★:声、出てた？アタシ？ヤベ。だよな。うーわ、はずかしー
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:すこし、見惚れて…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130029")


	--★★マルディサント★★:ナニ見惚れてんだよ…！！
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130030")


	--★★ディナタン★★:ご、ごめんなさい…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130031")

	PlayAction(Actor002,"to  Std_Angry")

	--★★マルディサント★★:超嬉しいだろうが！！
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:な、なによりです…っ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130033")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:授業始まってる時間だろが！！<br>サボってんじゃねえぞ！！
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130034")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:それはそうですね、お互い
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:な、な、な、悪ィんだけどよこのことヒミツにしといてくれよ
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130036")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:だ、誰にも言いません
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130037")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:………信じられねえ
	Talk(Actor002,"NPCNAME_0127","speech","L","MA_01104_130039")


	--★★ディナタン★★:えーっ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130040")

-- ▼直接出力
--マルディサント,CHRNAME_MALADISANT @名前変更
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:アタシ、マルディサント<br>名前聞かせろよ。見ねえカオだな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130041")

-- ▼直接出力
OpenFirstAppearance(Actor002)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:ディナタン、です…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130042")

	change_face(Actor002,"Surprise")

	--★★マルディサント★★:アンタ、転校生か！<br>円卓の騎士に喧嘩売ったヤツの妹だとか…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130043")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:ますます信用ならねえぜ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130044")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:ええーっ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_130045")


	--★★マルディサント★★:名前は覚えたいーかディナタン
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130046")


	--★★マルディサント★★:アンタの立場が今以上悪くなったらオニーサンともども学園にいらんなくなるだろ？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130047")


	--★★マルディサント★★:サボりについてアンタが教師に突っ込まれたら<br>こう言うんだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130049")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:「非行少女に絡まれた」ってな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_130050")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA011041301", "content_still_10101002_image", "101010020_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
