-- このluaスクリプトは、MA_01105_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera003 = SetTemplate("Actor003",-135,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
load_image("102010030_StillImage", "content_still_10201003_image", "102010030_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.5)
-- ▲直接出力

	--★★マーリン★★:扉を開くすべはお決まりで、主様？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_270002")


	--★★アーサー★★:中から開けてもらうほか<br>ないだろうな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270003")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★アーサー★★:キャメリアードを奪還するぞ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01105_270005")

	close_cutin()
-- ▼直接出力
DontChangeRandomCamera(true)
CloseTalkWindow()
show_image("102010030_StillImage", 0.0, 0.0, 0.3,false,false)
wait_time(0.6)
-- ▲直接出力

	--★★知将ケイ★★:明朝、ログレスを発った本隊は
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270006")

-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力

	--★★知将ケイ★★:明後日にはキャメリアードの前に広がる<br>ソールズベリー平原でカレドニア軍とぶつかる
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270007")


	--★★知将ケイ★★:此度の戦はランスロットが指揮を執る<br>敵軍も戦力の大半を出さざるをえまい
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270008")


	--★★知将ケイ★★:そこで、貴公らは少数で<br>手薄になったキャメリアード城に侵入し──
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270009")


	--★★知将ケイ★★:城を制圧してもらいたい
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270010")


	--★★ノワール★★:…ソールズベリー平原は身を隠す場所がない<br>敵に見つからずに城に侵入は難しい
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270011")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
hide_image(1.0)
wait_time(1.0)
-- ▲直接出力

	--★★アーサー★★:さすが<br>もと傭兵団長、地形にも詳しいな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270012")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★マーリン★★:転移が出来れば、いかがでしょうか？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_270013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ノワール★★:…！？<br>そうか、そのための偵察だったのか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270014")


	--★★マーリン★★:城内深くまでお邪魔いたしました<br>転移による再侵入が可能です
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_270015")


	--★★ノワール★★:転移、すごい
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270016")

	change_face(Actor001,"Surprise")

	--★★アーサー★★:転移、すごいよなあ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:１度使うと再び起動できるようになるまで<br>数時間かかりますけれどね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_270018")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★ノワール★★:これで一気に敵の中心部に到達し<br>キャメリアード王城を叩ける…！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270019")


	--★★知将ケイ★★:混乱に乗じて王城中のバルバロイを掃討<br>出来ることなら殲滅し、速やかな撤退を
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★アーサー★★:ノワール、お前がかつて少数の兵のみで<br>ランスロットの目前まで斬り込んだ腕を見込んだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270021")

	change_face(Actor001,"Smile")

	--★★アーサー★★:これがバルバロイへの反攻の第一歩になる<br>傭兵団の無念を晴らせ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01105_270025","MA_01105_270026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor002,"Smile")

	--★★ノワール★★:ありがとう、アーサー
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270028")

	change_face(Actor001,"Normal")

	--★★アーサー★★:王として当然のことをしたまでだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270029")

	change_face(Actor001,"Normal")

	--★★アーサー★★:そして学園に引き入れた<br>俺としての義務を果たすべくな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:言われなくても、そうするさ…！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270032")

	change_face(Actor001,"Smile")

	--★★アーサー★★:粋な計らいだろう？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270033")

	change_face(Actor002,"Smile")

	--★★ノワール★★:感謝する！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270034")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★アーサー★★:…それからまあ<br>ちょっと困ったことがあってだな？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270036")

	change_face(Actor002,"Normal")

	--★★ノワール★★:…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270037")

	change_face(Actor001,"Normal")

	--★★アーサー★★:まあ、キャメリアード王レオデグランスと<br>我らログレスとは旧知の仲なわけだが…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:この学園には実は、大事な宝があってだな<br>レオデグランス王から預かったものなんだが…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270039")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★アーサー★★:万が一この戦のあいだに持っていかれてしまうと<br>レオデグランス王が大変喜んでしまうんだなあ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270040")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_No")
turn_chara(Actor003,-170,0.3)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★知将ケイ★★:ああ～それはマズイですなー<br>戦いに影響を及ぼしかねんー
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270041")


	--★★アーサー★★:ただ、まー、今日はまだ五月だし？<br>戦いもいわば祭だし？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★マーリン★★:ああ！そのあいだであれば無礼講として<br>確か不問とされることもあったような
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_270044")


	--★★アーサー★★:なんだったかなー
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270046")

	change_face(Actor003,"Normal")

	--★★知将ケイ★★:なんだったかー
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01105_270047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:なんでしたかねー
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01105_270048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:…ふっ、ははっ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270049")

	open_cutin(1,1)
	on_cutin(1,Actor004,"Smile")

	--★★マーリン★★:スタンド・バイ・ユアラウンド
	Talk(Actor004,"CHRNAME_MERLIN","speech","N","MA_01105_270051")

	close_cutin()

	--★★ノワール★★:フォー・ラウンド！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_270052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:扉を叩いてやってくれ、ノワール
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01105_270053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010030_StillImage", "content_still_10201003_image", "102010030_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
