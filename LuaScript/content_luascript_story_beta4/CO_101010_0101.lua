-- このluaスクリプトは、CO_101010_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:ノワール、少しいいか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010002")

	open_select_window_tag(Actor001,"Normal","CO_101010_01010004","CO_101010_01010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010007")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:学園生活の調子はどうだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:見てのとおりだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、ちょっと忙しいんだ悪いがまたにしてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか、すまない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010015")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、どうしても今話しておかねばならないことがあるんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010016")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:お前の成績のことだが…正直あまり芳しくない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010018")


	--★★ランスロット★★:まだこの学園に来て日が浅い以上いたしかたない部分もあるが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺はずっと傭兵をやってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010021")


	--★★ノワール★★:勉強してる暇なんかなかったんだから少しくらい成績が悪くても仕方ないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そもそも、まさか俺だってこんなふうに学校に通うことになるなんて思ってなかったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それはわかっているだがこの学園に来た以上、学べるだけ学ぶべきだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010024")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなこと言ったってじゃあ、どうすればいいんだよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:俺が補習をしてやるお前は地頭は悪くないんだ、すぐに追いつく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010026")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだよ、先生みたいなこと言って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:これでも一応、先生だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010028")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:似合ってない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010029")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:それは理解しているつもりだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:だが、俺にはお前を推薦しこの学園に入れた責任がある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010031")

-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力

	--★★ランスロット★★:このまま見て見ぬふりをするわけにはいかない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺の成績が悪いとあんたの面子がつぶれるってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010033")

-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力

	--★★ランスロット★★:そういうわけじゃない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:…ま、なんでもいいけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_01010035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:とにかく、始めるぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_01010036")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ1_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
