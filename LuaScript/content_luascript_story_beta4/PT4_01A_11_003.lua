-- このluaスクリプトは、PT4_01A_11_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん、聞いたよ<br>スノードン山に行くんでしょ！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01A_11_0030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>あの山に聖杯が出現するらしいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030003")

-- ▼直接出力
PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力

	--★★マルディサント★★:登るだけでも一苦労らしいのに<br>ローマの連中とやり合う可能性も高いんだろ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01A_11_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ローマ軍との戦闘は確実に発生するだろうな<br>…しかも、おそらくは本隊だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030005")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:マジかよ<br>死にに行くようなもんじゃねえか！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01A_11_0030006")


	--★★ノワール★★:それでも行くしかない<br>聖杯を手に入れなきゃ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:それなら兄さん、私も一緒に行く
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01A_11_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや、ディナタンとマルディサントは<br>学園に残っていて欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030009")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:どうして！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01A_11_0030010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:さっきも言ったとおり<br>今回の相手はローマ軍の本隊だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:円卓だけでなく、ログレス軍の大半が<br>スノードン山へ向かうことになる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そのあいだに<br>ログレスや学園を守ってくれる人間が必要だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01A_11_0030013")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:それはわかるけど、でも…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01A_11_0030014")

-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:落ち着けよ、ディーナ<br>オニーサンの言うことはもっともだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01A_11_0030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:マァルまで…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01A_11_0030016")


	--★★マルディサント★★:それに、ディーナだからこそ<br>大事な役目を任せるって言ってんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01A_11_0030017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:ここはぐっとこらえて<br>その信頼に応えるべきじゃねーの
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01A_11_0030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:…わかった。私は学園で待ってるね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01A_11_0030019")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:必ず無事に帰って来いよ、オニーサン<br>ディーナを悲しませる奴はアタシが許さねえ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01A_11_0030020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
